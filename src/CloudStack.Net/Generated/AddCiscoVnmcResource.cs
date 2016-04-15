using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddCiscoVnmcResourceRequest : APIRequest
    {
        public AddCiscoVnmcResourceRequest() : base("addCiscoVnmcResource") {}

        /// <summary>
        /// Hostname or ip address of the Cisco VNMC Controller.
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to access the Cisco VNMC Controller API
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to access the Cisco VNMC Controller API
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Cisco Vnmc Controller
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoVnmcResourceResponse AddCiscoVnmcResource(AddCiscoVnmcResourceRequest request);
        Task<CiscoVnmcResourceResponse> AddCiscoVnmcResourceAsync(AddCiscoVnmcResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoVnmcResourceResponse AddCiscoVnmcResource(AddCiscoVnmcResourceRequest request) => _proxy.Request<CiscoVnmcResourceResponse>(request);
        public Task<CiscoVnmcResourceResponse> AddCiscoVnmcResourceAsync(AddCiscoVnmcResourceRequest request) => _proxy.RequestAsync<CiscoVnmcResourceResponse>(request);
    }
}
