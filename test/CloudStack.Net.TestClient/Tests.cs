using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CloudStack.Net.TestClient
{
    /// <summary>
    /// Tests to verify correctness of SDK functionality.
    /// </summary>
    public class Tests
    {
        private Action<string> _logWriter;
        private Uri _serviceUri;
        private string _apiKey;
        private bool _deployStopped;
        private string _secretKey;
        private string _templateId;
        private string _networkId;
        private string _serviceOfferingId;
        private string _zoneId;
        private ICloudStackAPIProxy _proxy;
        private ICloudStackAPIClient _client;
        
        public Tests(Action<string> log)
        {
            _logWriter = log;
            Setup();
        }

        #region Low level tests

        internal void TriggerBadApiUrlException()
        {
            try
            {
                string apiUrl = _serviceUri.AbsoluteUri.Substring(0, _serviceUri.AbsoluteUri.Length - 3);

                _logWriter("Test bad XML exception triggered by GUI URL" + apiUrl);
                var request = new StartVirtualMachineRequest();
                request.Parameters["id"] = "invalid-machine-id";
                _client.StartVirtualMachine(request);
                System.Diagnostics.Debug.Fail("Test should have triggered CloudStackException");
            }
            catch (CloudStackException cex)
            {
                _logWriter(cex.Message);
                _logWriter("Test PASSED");
            }
        }

        internal void TriggerBadApiCallException()
        {
            try
            {
                _logWriter("Test API call with wrong parameters");
                CreateVolumeRequest request = new CreateVolumeRequest()
                {
                    Size = 16,
                    VolumeName = "test",
                };

                request.Parameters[nameof(request.DiskOfferingId)] = "diskOfferingFoo";
                request.Parameters[nameof(request.ZoneId)] = "zonefoo";

                _client.CreateVolume(request);
                System.Diagnostics.Debug.Fail("Test should have triggered CloudStackException");
            }
            catch (CloudStackException cex)
            {
                _logWriter(cex.Message);
                _logWriter("Test PASSED");
            }
        }

        internal void ListAsyncJobs()
        {
            try
            {
                var deployResp = _client.ListAsyncJobs(new ListAsyncJobsRequest());
                _logWriter(deployResp.ToString());
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
            }
        }

        internal void QueryAsyncJobResult(string jobid)
        {
            try
            {
                var deployResp = _client.QueryAsyncJobResult(new QueryAsyncJobResultRequest { Id = Guid.Parse(jobid) });
                _logWriter(deployResp.ToString());
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
            }
        }

        #endregion

        #region Network tests

        internal void ListNetworks()
        {
            try
            {
                ListNetworksRequest request = new ListNetworksRequest();
                var result = _client.ListNetworks(request);
                _logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter("Error listing networks: " + ex.Message);
            }
        }

        internal void ListNetworkOfferings()
        {
            try
            {
                ListNetworkOfferingsRequest request = new ListNetworkOfferingsRequest();
                var result = _client.ListNetworkOfferings(request);
                _logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter("Error listing network offerings: " + ex.Message);
            }
        }

        #endregion

        #region Security Group tests

        internal void CreateSecurityGroup(string securityGroupName)
        {
            try
            {
                CreateSecurityGroupRequest request = new CreateSecurityGroupRequest()
                {
                    SecurityGroupName = securityGroupName,
                    Description = "My security group"
                };
                var response = _client.CreateSecurityGroup(request);
                WriteLog("Created Security Group {0}, Id {1}, Description \"{2}\"", response.Name, response.Id, response.Description);
            }
            catch (Exception e)
            {
                WriteLog("Exception during CreateSecurityGroup {0}", e);
            }
        }

        internal void AuthorizeSecurityGroupIngress(string securityGroupName)
        {
            try
            {
                AuthorizeSecurityGroupIngressRequest request = new AuthorizeSecurityGroupIngressRequest()
                {
                    SecurityGroupName = securityGroupName,
                    Protocol = ProtocolType.Tcp.ToString(),
                    StartPort = 80,
                    EndPort = 80,
                    CidrList = new[] { "0.0.0.0/0" }.ToList()
                };
                _client.AuthorizeSecurityGroupIngress(request);

                request = new AuthorizeSecurityGroupIngressRequest()
                {
                    SecurityGroupName = "TestSecurityGroup",
                    Protocol = ProtocolType.Tcp.ToString(),
                    StartPort = 22,
                    EndPort = 22,
                    CidrList = new[] { "0.0.0.0/0" }.ToList()
                };
                _client.AuthorizeSecurityGroupIngress(request);
            }
            catch (Exception e)
            {
                WriteLog("Exception during AuthorizeSecurityGroupIngress {0}", e);
            }
        }

        internal void ListSecurityGroups()
        {
            try
            {
                ListSecurityGroupsRequest request = new ListSecurityGroupsRequest();
                var response = _client.ListSecurityGroups(request);
                foreach (SecurityGroupResponse sg in response.Results)
                {
                    WriteLog("Security Group: {0} ", sg.Name);
                    if (sg.Ingressrule != null)
                    {
                        foreach (SecurityGroupRuleResponse rule in sg.Ingressrule)
                        {
                            WriteLog(rule.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                WriteLog("Exception during ListSecurityGroups {0}", e);
            }
        }

        #endregion

        #region Service Offering tests

        internal void ListServiceOfferings()
        {
            try
            {
                ListServiceOfferingsRequest request = new ListServiceOfferingsRequest();
                var result = _client.ListServiceOfferings(request);
                _logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter("Error listing service offerings: " + ex.Message);
            }
        }

        #endregion

        #region Template tests

        internal void ListTemplates(string filter)
        {
            ListTemplatesRequest request = new ListTemplatesRequest()
            {
                TemplateFilter = filter
            };
            var response = _client.ListTemplates(request);
            _logWriter(response.ToString());
        }

        #endregion

        #region Virtual Machine tests

        internal string DeployVirtualMachine()
        {
            string id = string.Empty;
            try
            {
                DeployVirtualMachineRequest request = new DeployVirtualMachineRequest()
                {
                    TemplateId = Guid.Parse(_templateId),
                    ServiceOfferingId = Guid.Parse(_serviceOfferingId),
                    DisplayName = "Test-Generated",
                    ZoneId = Guid.Parse(_zoneId),
                    UserData = "my user data",
                    StartVm = !_deployStopped
                };
                if (!string.IsNullOrEmpty(this._networkId))
                {
                    request.NetworkIds = new[] { long.Parse(_networkId) }.ToList();
                }
                id = _client.DeployVirtualMachine(request).Id;
                _logWriter("Deployed new VM, id " + id);
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
                System.Diagnostics.Debug.Fail("Not supposed to throw during deploy VM");
            }
            return id;
        }

        internal void ListVirtualMachines()
        {
            try
            {
                ListVirtualMachinesRequest request = new ListVirtualMachinesRequest()
                {
                    ZoneId = Guid.Parse(_zoneId)
                };
                var response = _client.ListVirtualMachines(request);
                _logWriter(response.ToString());
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
            }
        }

        internal void StartVirtualMachine(string id)
        {
            try
            {
                _client.StartVirtualMachine(new StartVirtualMachineRequest { Id = Guid.Parse(id) });
                _logWriter("Sent start to VirtualMachine " + id);
            }
            catch (System.Exception ex)
            {
                _logWriter("Error starting VirtualMachine:" + ex.Message);
            }
        }

        internal void StopVirtualMachine(string id, bool force)
        {
            try
            {
                _client.StopVirtualMachine(new StopVirtualMachineRequest { Id = Guid.Parse(id), Forced = force });
                _logWriter("Sent start to VirtualMachine " + id);
            }
            catch (System.Exception ex)
            {
                _logWriter("Error stoppng VirtualMachine:" + ex.Message);
            }
        }

        #endregion

        #region Volume tests

        internal string CreateVolume()
        {
            string volId = string.Empty;

            try
            {
                ListDiskOfferingsRequest request = new ListDiskOfferingsRequest();
                var doffers = _client.ListDiskOfferings(request);

                DiskOfferingResponse customOffering = null;
                foreach (var offer in doffers.Results)
                {
                    if (offer.Iscustomized)
                    {
                        customOffering = offer;
                        break;
                    }
                }
                System.Diagnostics.Debug.Assert(customOffering != null, "There should be at least one custom disk offering defined");
                CreateVolumeRequest req = new CreateVolumeRequest()
                {
                    DiskOfferingId = Guid.Parse(customOffering.Id),
                    Size = 16,
                    VolumeName = "testVolume",
                    ZoneId = Guid.Parse(_zoneId)
                };
                volId = _client.CreateVolume(req).Id;
                _logWriter("Created volume id is " + volId);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.Fail("Not supposed to throw during create volume");
                this._logWriter(ex.Message);
            }
            return volId;
        }

        internal void AttachVolume(string volumeId, string vmId)
        {
            long device = 5;

            try
            {
                AttachVolumeRequest request = new AttachVolumeRequest()
                {
                    Id = Guid.Parse(volumeId),
                    VirtualMachineId = Guid.Parse(vmId),
                    DeviceId = device
                };
                _client.AttachVolume(request);
                _logWriter("Attached volume " + volumeId + " to vm " + vmId);
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
            }
        }

        internal void DetachVolume(string volumeId, string vmId)
        {
            try
            {
                DetachVolumeRequest request = new DetachVolumeRequest()
                {
                    Id = Guid.Parse(volumeId),
                    VirtualMachineId = Guid.Parse(vmId),
                };
                _client.DetachVolume(request);
                _logWriter("Detached volume " + volumeId + " from vm " + vmId);
            }
            catch (System.Exception ex)
            {
                _logWriter(ex.Message);
            }
        }

        internal void DeleteVolume(string volumeId)
        {
            try
            {
                _client.DeleteVolume(new DeleteVolumeRequest { Id = Guid.Parse(volumeId) });
                _logWriter("Deleted volume " + volumeId);
            }
            catch (System.Exception wex)
            {
                _logWriter(wex.Message);
            }
        }

        internal void ListVolumes()
        {
            try
            {
                ListVolumesRequest request = new ListVolumesRequest();
                var response = _client.ListVolumes(request);
                _logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter("Error listing network volumes: " + ex.Message);
            }
        }

        internal void ListDiskOfferings()
        {
            try
            {
                ListDiskOfferingsRequest request = new ListDiskOfferingsRequest();
                var response = _client.ListDiskOfferings(request);
                _logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter("Error listing network volumes: " + ex.Message);
            }
        }

        #endregion

        #region Zone tests

        internal void ListZones()
        {
            try
            {
                ListZonesRequest request = new ListZonesRequest();
                var response = _client.ListZones(request);
                _logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                _logWriter(ex.Message);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Copies test values from the application's properties.
        /// </summary>
        private void Setup()
        {
            _apiKey = Properties.Settings.Default.User;
            _secretKey = Properties.Settings.Default.Password;
            _serviceUri = new Uri(Properties.Settings.Default.URL);

            _proxy = new CloudStackAPIProxy(_serviceUri.ToString(), _apiKey, _secretKey);
            _client = new CloudStackAPIClient(_proxy);

            _templateId = Properties.Settings.Default.TemplateId;
            _networkId = Properties.Settings.Default.SubnetId;
            _serviceOfferingId = Properties.Settings.Default.ServiceOfferingId;

            this._deployStopped = Properties.Settings.Default.DeployStopped;
            _zoneId = Properties.Settings.Default.ZoneId;
        }

        private void WriteLog(string format, params object[] args)
        {
            _logWriter(string.Format(CultureInfo.InvariantCulture, format, args));
        }

        #endregion
    }
}
