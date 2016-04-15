using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedClustersRequest : APIListRequest
    {
        public ListDedicatedClustersRequest() : base("listDedicatedClusters") {}

        /// <summary>
        /// the name of the account associated with the cluster. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list dedicated clusters by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return GetParameterValue<Guid>(nameof(AffinityGroupId).ToLower()); }
            set { SetParameterValue(nameof(AffinityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain associated with the cluster
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists dedicated clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateClusterResponse> ListDedicatedClusters(ListDedicatedClustersRequest request);
        Task<ListResponse<DedicateClusterResponse>> ListDedicatedClustersAsync(ListDedicatedClustersRequest request);
        ListResponse<DedicateClusterResponse> ListDedicatedClustersAllPages(ListDedicatedClustersRequest request);
        Task<ListResponse<DedicateClusterResponse>> ListDedicatedClustersAllPagesAsync(ListDedicatedClustersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateClusterResponse> ListDedicatedClusters(ListDedicatedClustersRequest request) => _proxy.Request<ListResponse<DedicateClusterResponse>>(request);
        public Task<ListResponse<DedicateClusterResponse>> ListDedicatedClustersAsync(ListDedicatedClustersRequest request) => _proxy.RequestAsync<ListResponse<DedicateClusterResponse>>(request);
        public ListResponse<DedicateClusterResponse> ListDedicatedClustersAllPages(ListDedicatedClustersRequest request) => _proxy.RequestAllPages<DedicateClusterResponse>(request);
        public Task<ListResponse<DedicateClusterResponse>> ListDedicatedClustersAllPagesAsync(ListDedicatedClustersRequest request) => _proxy.RequestAllPagesAsync<DedicateClusterResponse>(request);
    }
}
