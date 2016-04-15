using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListClustersRequest : APIListRequest
    {
        public ListClustersRequest() : base("listClusters") {}

        /// <summary>
        /// lists clusters by allocation state
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by cluster type
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by hypervisor type
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by the cluster ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState {
            get { return GetParameterValue<string>(nameof(ManagedState).ToLower()); }
            set { SetParameterValue(nameof(ManagedState).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by the cluster name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by Pod ID
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the capacity of the clusters
        /// </summary>
        public bool? ShowCapacities {
            get { return GetParameterValue<bool?>(nameof(ShowCapacities).ToLower()); }
            set { SetParameterValue(nameof(ShowCapacities).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by Zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ClusterResponse> ListClusters(ListClustersRequest request);
        Task<ListResponse<ClusterResponse>> ListClustersAsync(ListClustersRequest request);
        ListResponse<ClusterResponse> ListClustersAllPages(ListClustersRequest request);
        Task<ListResponse<ClusterResponse>> ListClustersAllPagesAsync(ListClustersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ClusterResponse> ListClusters(ListClustersRequest request) => _proxy.Request<ListResponse<ClusterResponse>>(request);
        public Task<ListResponse<ClusterResponse>> ListClustersAsync(ListClustersRequest request) => _proxy.RequestAsync<ListResponse<ClusterResponse>>(request);
        public ListResponse<ClusterResponse> ListClustersAllPages(ListClustersRequest request) => _proxy.RequestAllPages<ClusterResponse>(request);
        public Task<ListResponse<ClusterResponse>> ListClustersAllPagesAsync(ListClustersRequest request) => _proxy.RequestAllPagesAsync<ClusterResponse>(request);
    }
}
