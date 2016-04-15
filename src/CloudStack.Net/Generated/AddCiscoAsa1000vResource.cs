using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddCiscoAsa1000vResourceRequest : APIRequest
    {
        public AddCiscoAsa1000vResourceRequest() : base("addCiscoAsa1000vResource") {}

        /// <summary>
        /// the Cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// Nexus port profile associated with inside interface of ASA 1000v
        /// </summary>
        public string Insideportprofile {
            get { return GetParameterValue<string>(nameof(Insideportprofile).ToLower()); }
            set { SetParameterValue(nameof(Insideportprofile).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Cisco Asa 1000v appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoAsa1000vResourceResponse AddCiscoAsa1000vResource(AddCiscoAsa1000vResourceRequest request);
        Task<CiscoAsa1000vResourceResponse> AddCiscoAsa1000vResourceAsync(AddCiscoAsa1000vResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoAsa1000vResourceResponse AddCiscoAsa1000vResource(AddCiscoAsa1000vResourceRequest request) => _proxy.Request<CiscoAsa1000vResourceResponse>(request);
        public Task<CiscoAsa1000vResourceResponse> AddCiscoAsa1000vResourceAsync(AddCiscoAsa1000vResourceRequest request) => _proxy.RequestAsync<CiscoAsa1000vResourceResponse>(request);
    }
}
