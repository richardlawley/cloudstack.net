using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Release the dedication for cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
