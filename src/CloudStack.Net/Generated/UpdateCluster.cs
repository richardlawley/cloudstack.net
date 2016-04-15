using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// the cluster name
        /// </summary>
        public string ClusterName {
            get { return GetParameterValue<string>(nameof(ClusterName).ToLower()); }
            set { SetParameterValue(nameof(ClusterName).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the cluster
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState {
            get { return GetParameterValue<string>(nameof(ManagedState).ToLower()); }
            set { SetParameterValue(nameof(ManagedState).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates an existing cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ClusterResponse UpdateCluster(UpdateClusterRequest request);
        Task<ClusterResponse> UpdateClusterAsync(UpdateClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ClusterResponse UpdateCluster(UpdateClusterRequest request) => _proxy.Request<ClusterResponse>(request);
        public Task<ClusterResponse> UpdateClusterAsync(UpdateClusterRequest request) => _proxy.RequestAsync<ClusterResponse>(request);
    }
}
