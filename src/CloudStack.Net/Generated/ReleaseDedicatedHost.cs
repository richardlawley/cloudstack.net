using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedHostRequest : APIRequest
    {
        public ReleaseDedicatedHostRequest() : base("releaseDedicatedHost") {}

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Release the dedication for host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedHostAsync(ReleaseDedicatedHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedHostAsync(ReleaseDedicatedHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
