using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateClusterRequest : APIRequest
    {
        public DedicateClusterRequest() : base("dedicateCluster") {}

        /// <summary>
        /// the ID of the Cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

    }
    /// <summary>
    /// Dedicate an existing cluster
    /// </summary>
    /// <summary>
    /// Dedicate an existing cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DedicateClusterResponse DedicateCluster(DedicateClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DedicateClusterResponse DedicateCluster(DedicateClusterRequest request) => _proxy.Request<DedicateClusterResponse>(request);
    }
}
