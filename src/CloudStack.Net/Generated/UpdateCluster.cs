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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// the cluster name
        /// </summary>
        public string ClusterName {
            get { return (string) Parameters[nameof(ClusterName).ToLower()]; }
            set { Parameters[nameof(ClusterName).ToLower()] = value; }
        }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string ClusterType {
            get { return (string) Parameters[nameof(ClusterType).ToLower()]; }
            set { Parameters[nameof(ClusterType).ToLower()] = value; }
        }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState {
            get { return (string) Parameters[nameof(ManagedState).ToLower()]; }
            set { Parameters[nameof(ManagedState).ToLower()] = value; }
        }

    }
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
