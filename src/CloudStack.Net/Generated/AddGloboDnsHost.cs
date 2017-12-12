using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGloboDnsHostRequest : APIRequest
    {
        public AddGloboDnsHostRequest() : base("addGloboDnsHost") {}

        /// <summary>
        /// Password for GloboDNS
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
        /// GloboDNS url
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Username for GloboDNS
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds the GloboDNS external host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddGloboDnsHost(AddGloboDnsHostRequest request);
        Task<AsyncJobResponse> AddGloboDnsHostAsync(AddGloboDnsHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddGloboDnsHost(AddGloboDnsHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGloboDnsHostAsync(AddGloboDnsHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
