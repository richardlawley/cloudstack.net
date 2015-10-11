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
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by cluster type
        /// </summary>
        public string ClusterType {
            get { return (string) Parameters[nameof(ClusterType).ToLower()]; }
            set { Parameters[nameof(ClusterType).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by hypervisor type
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by the cluster ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState {
            get { return (string) Parameters[nameof(ManagedState).ToLower()]; }
            set { Parameters[nameof(ManagedState).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by the cluster name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by Pod ID
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// flag to display the capacity of the clusters
        /// </summary>
        public bool? ShowCapacities {
            get { return (bool?) Parameters[nameof(ShowCapacities).ToLower()]; }
            set { Parameters[nameof(ShowCapacities).ToLower()] = value; }
        }

        /// <summary>
        /// lists clusters by Zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

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
