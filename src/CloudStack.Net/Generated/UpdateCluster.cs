using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateClusterRequest : APIRequest
    {
        public UpdateClusterRequest() : base("updateCluster") {}

        /// <summary>
        /// the ID of the Cluster
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the cluster name
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState { get; set; }

    }
    /// <summary>
    /// Updates an existing cluster
    /// </summary>
    /// <summary>
    /// Updates an existing cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ClusterResponse UpdateCluster(UpdateClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ClusterResponse UpdateCluster(UpdateClusterRequest request) => _proxy.Request<ClusterResponse>(request);
    }
}
