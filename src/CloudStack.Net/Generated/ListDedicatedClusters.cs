using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedClustersRequest : APIRequest
    {
        public ListDedicatedClustersRequest() : base("listDedicatedClusters") {}

        /// <summary>
        /// the name of the account associated with the cluster. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list dedicated clusters by affinity group
        /// </summary>
        public Guid AffinityGroupId { get; set; }

        /// <summary>
        /// the ID of the cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the ID of the domain associated with the cluster
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists dedicated clusters.
    /// </summary>
    /// <summary>
    /// Lists dedicated clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateClusterResponse> ListDedicatedClusters(ListDedicatedClustersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateClusterResponse> ListDedicatedClusters(ListDedicatedClustersRequest request) => _proxy.Request<ListResponse<DedicateClusterResponse>>(request);
    }
}
