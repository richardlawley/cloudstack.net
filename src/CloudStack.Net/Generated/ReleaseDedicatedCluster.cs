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
        public Guid ClusterId { get; set; }

    }
    /// <summary>
    /// Release the dedication for cluster
    /// </summary>
    /// <summary>
    /// Release the dedication for cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseDedicatedCluster(ReleaseDedicatedClusterRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
