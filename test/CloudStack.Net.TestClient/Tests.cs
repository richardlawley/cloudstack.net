using System;
using System.Collections.Generic;
using System.Linq;
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
        private Action<string> logWriter;
        private Uri serviceUri;
        private string apiKey;
        private bool deployStopped;
        private string secretKey;
        private string templateId;
        private string networkId;
        private string serviceOfferingId;
        private string zoneId;

        public Tests(Action<string> log)
        {
            logWriter = log;
            Setup();
        }

        #region Low level tests

        internal void TriggerBadApiUrlException()
        {
            try
            {
                string apiUrl = serviceUri.AbsoluteUri.Substring(0, serviceUri.AbsoluteUri.Length - 3);

                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                logWriter("Test bad XML exception triggered by GUI URL" + apiUrl);
                session.StartVirtualMachine("invalid-machine-id");
                System.Diagnostics.Debug.Fail("Test should have triggered CloudStackException");
            }
            catch (CloudStackException cex)
            {
                logWriter(cex.Message);
                logWriter("Test PASSED");
            }
        }

        internal void TriggerBadApiCallException()
        {
            try
            {
                logWriter("Test API call with wrong parameters");
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                CreateVolumeRequest request = new CreateVolumeRequest()
                {
                    DiskOfferingId = "diskOfferingFoo",
                    Size = 16,
                    Name = "test",
                    ZoneId = "zonefoo"
                };
                session.CreateVolume(request);
                System.Diagnostics.Debug.Fail("Test should have triggered CloudStackException");
            }
            catch (CloudStackException cex)
            {
                logWriter(cex.Message);
                logWriter("Test PASSED");
            }
        }

        internal void ListAsyncJobs()
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                APIRequest request = new APIRequest("listAsyncJobs");
                var deployResp = session.SendRequest(request);
                logWriter(deployResp.ToString());
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
            }
        }

        internal void QueryAsyncJobResult(string jobid)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                var deployResp = CloudStack.SDK.AsyncSupport.QueryAsyncJobResult(session, jobid);
                logWriter(deployResp.ToString());
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
            }
        }

        #endregion

        #region Network tests

        internal void ListNetworks()
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                ListNetworksRequest request = new ListNetworksRequest();
                ListNetworksResponse result = session.ListNetworks(request);
                logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter("Error listing networks: " + ex.Message);
            }
        }

        internal void ListNetworkOfferings()
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                ListNetworkOfferingsRequest request = new ListNetworkOfferingsRequest();
                var result = session.ListNetworkOfferings(request);
                logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter("Error listing network offerings: " + ex.Message);
            }
        }

        #endregion

        #region Security Group tests

        internal void CreateSecurityGroup(string securityGroupName)
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                CreateSecurityGroupRequest request = new CreateSecurityGroupRequest()
                {
                    Name = securityGroupName,
                    Description = "My security group"
                };
                CreateSecurityGroupResponse response = session.CreateSecurityGroup(request);
                SecurityGroup group = response.SecurityGroup;
                WriteLog("Created Security Group {0}, Id {1}, Description \"{2}\"", group.Name, group.Id, group.Description);
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
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                AuthorizeSecurityGroupIngressRequest request = new AuthorizeSecurityGroupIngressRequest()
                {
                    SecurityGroupName = securityGroupName,
                    Protocol = ProtocolType.tcp,
                    StartPort = 80,
                    EndPort = 80,
                    CidrList = "0.0.0.0/0"
                };
                session.AuthorizeSecurityGroupIngress(request);

                request = new AuthorizeSecurityGroupIngressRequest()
                {
                    SecurityGroupName = "TestSecurityGroup",
                    Protocol = ProtocolType.tcp,
                    StartPort = 22,
                    EndPort = 22,
                    CidrList = "0.0.0.0/0"
                };
                session.AuthorizeSecurityGroupIngress(request);
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
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                ListSecurityGroupsRequest request = new ListSecurityGroupsRequest();
                ListSecurityGroupsResponse response = session.ListSecurityGroups(request);
                foreach (SecurityGroup sg in response.SecurityGroup)
                {
                    WriteLog("Security Group: {0} ", sg.Name);
                    if (sg.IngressRule != null)
                    {
                        foreach (IngressRule rule in sg.IngressRule)
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
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                ListServiceOfferingsRequest request = new ListServiceOfferingsRequest();
                var result = session.ListServiceOfferings(request);
                logWriter(result.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter("Error listing service offerings: " + ex.Message);
            }
        }

        #endregion

        #region Template tests

        internal void ListTemplates(string filter)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            ListTemplatesRequest request = new ListTemplatesRequest()
            {
                TemplateFilter = filter
            };
            ListTemplatesResponse response = session.ListTemplates(request);
            logWriter(response.ToString());
        }

        #endregion

        #region Virtual Machine tests

        internal string DeployVirtualMachine()
        {
            string id = string.Empty;
            var session = new CloudStack.SDK.Client(serviceUri, apiKey, secretKey);
            try
            {
                DeployVirtualMachineRequest request = new DeployVirtualMachineRequest()
                {
                    TemplateId = templateId,
                    ServiceOfferingId = serviceOfferingId,
                    DisplayName = "Test-Generated",
                    ZoneId = zoneId,
                    UserData = "my user data",
                    StartVm = !deployStopped
                };
                if (!string.IsNullOrEmpty(this.networkId))
                {
                    request.WithNetworkIds(networkId);
                }
                id = session.DeployVirtualMachine(request);
                logWriter("Deployed new VM, id " + id);
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
                System.Diagnostics.Debug.Fail("Not supposed to throw during deploy VM");
            }
            return id;
        }

        internal void ListVirtualMachines()
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                ListVirtualMachinesRequest request = new ListVirtualMachinesRequest()
                {
                    ZoneId = zoneId
                };
                ListVirtualMachinesResponse response = session.ListVirtualMachines(request);
                logWriter(response.ToString());
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
            }
        }

        internal void StartVirtualMachine(string id)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                session.StartVirtualMachine(id);
                logWriter("Sent start to VirtualMachine " + id);
            }
            catch (System.Exception ex)
            {
                logWriter("Error starting VirtualMachine:" + ex.Message);
            }
        }

        internal void StopVirtualMachine(string id, bool force)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                session.StopVirtualMachine(id, force);
                logWriter("Sent start to VirtualMachine " + id);
            }
            catch (System.Exception ex)
            {
                logWriter("Error stoppng VirtualMachine:" + ex.Message);
            }
        }

        #endregion

        #region Volume tests

        internal string CreateVolume()
        {
            var session = new Client(serviceUri, apiKey, secretKey);
            string volId = string.Empty;

            try
            {
                ListDiskOfferingsRequest request = new ListDiskOfferingsRequest();
                ListDiskOfferingsResponse doffers = session.ListDiskOfferings(request);

                DiskOffering customOffering = null;
                foreach (var offer in doffers.DiskOffering)
                {
                    if (offer.IsCustomized)
                    {
                        customOffering = offer;
                        break;
                    }
                }
                System.Diagnostics.Debug.Assert(customOffering != null, "There should be at least one custom disk offering defined");
                CreateVolumeRequest req = new CreateVolumeRequest()
                {
                    DiskOfferingId = customOffering.Id,
                    Size = 16,
                    Name = "testVolume",
                    ZoneId = zoneId
                };
                volId = session.CreateVolume(req);
                logWriter("Created volume id is " + volId);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.Fail("Not supposed to throw during create volume");
                this.logWriter(ex.Message);
            }
            return volId;
        }

        internal void AttachVolume(string volumeId, string vmId)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            string device = "5";

            try
            {
                AttachVolumeRequest request = new AttachVolumeRequest()
                {
                    Id = volumeId,
                    VirtualMachineId = vmId,
                    DeviceId = device
                };
                session.AttachVolume(request);
                logWriter("Attached volume " + volumeId + " to vm " + vmId);
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
            }
        }

        internal void DetachVolume(string volumeId, string vmId)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                DetachVolumeRequest request = new DetachVolumeRequest()
                {
                    Id = volumeId,
                    VirtualMachineId = vmId,
                };
                session.DetachVolume(request);
                logWriter("Detached volume " + volumeId + " from vm " + vmId);
            }
            catch (System.Exception ex)
            {
                logWriter(ex.Message);
            }
        }

        internal void DeleteVolume(string volumeId)
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                session.DeleteVolume(volumeId);
                logWriter("Deleted volume " + volumeId);
            }
            catch (System.Exception wex)
            {
                logWriter(wex.Message);
            }
        }

        internal void ListVolumes()
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                ListVolumesRequest request = new ListVolumesRequest();
                ListVolumesResponse response = session.ListVolumes(request);
                logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter("Error listing network volumes: " + ex.Message);
            }
        }

        internal void ListDiskOfferings()
        {
            try
            {
                var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
                ListDiskOfferingsRequest request = new ListDiskOfferingsRequest();
                ListDiskOfferingsResponse response = session.ListDiskOfferings(request);
                logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter("Error listing network volumes: " + ex.Message);
            }
        }

        #endregion

        #region Zone tests

        internal void ListZones()
        {
            var session = new CloudStackAPIClient(serviceUri.ToString(), apiKey, secretKey);
            try
            {
                ListZonesRequest request = new ListZonesRequest();
                ListZonesResponse response = session.ListZones(request);
                logWriter(response.ToString());
            }
            catch (System.Exception ex)
            {
                logWriter(ex.Message);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Copies test values from the application's properties.
        /// </summary>
        private void Setup()
        {
            apiKey = Properties.Settings.Default.User;
            secretKey = Client.CreateSecureString(Properties.Settings.Default.Password);
            serviceUri = new Uri(Properties.Settings.Default.URL);

            templateId = Properties.Settings.Default.TemplateId;
            networkId = Properties.Settings.Default.SubnetId;
            serviceOfferingId = Properties.Settings.Default.ServiceOfferingId;

            this.deployStopped = Properties.Settings.Default.DeployStopped;
            zoneId = Properties.Settings.Default.ZoneId;
        }

        private void WriteLog(string format, params object[] args)
        {
            logWriter(string.Format(CultureInfo.InvariantCulture, format, args));
        }

        #endregion
    }
}
