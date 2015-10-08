using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListClustersRequest : APIRequest
    {
        public ListClustersRequest() : base("listClusters") {}

        /// <summary>
        /// lists clusters by allocation state
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// lists clusters by cluster type
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// lists clusters by hypervisor type
        /// </summary>
        public string HypervisorType { get; set; }

        /// <summary>
        /// lists clusters by the cluster ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState { get; set; }

        /// <summary>
        /// lists clusters by the cluster name
        /// </summary>
        public string ClusterName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// lists clusters by Pod ID
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// flag to display the capacity of the clusters
        /// </summary>
        public bool? ShowCapacities { get; set; }

        /// <summary>
        /// lists clusters by Zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists clusters.
    /// </summary>
    /// <summary>
    /// Lists clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ClusterResponse> ListClusters(ListClustersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ClusterResponse> ListClusters(ListClustersRequest request) => _proxy.Request<ListResponse<ClusterResponse>>(request);
    }
}
