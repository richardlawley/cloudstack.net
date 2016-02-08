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
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// GloboDNS url
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Username for GloboDNS
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
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
        public AsyncJobResponse AddGloboDnsHost(AddGloboDnsHostRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGloboDnsHostAsync(AddGloboDnsHostRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
