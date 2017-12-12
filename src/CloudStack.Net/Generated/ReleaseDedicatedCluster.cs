using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedClusterRequest : APIRequest
    {
        public ReleaseDedicatedClusterRequest() : base("releaseDedicatedCluster") {}

        /// <summary>
        /// the ID of the Cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Release the dedication for cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedClusterAsync(ReleaseDedicatedClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedClusterAsync(ReleaseDedicatedClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
