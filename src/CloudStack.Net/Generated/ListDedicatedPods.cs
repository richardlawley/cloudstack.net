using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedPodsRequest : APIListRequest
    {
        public ListDedicatedPodsRequest() : base("listDedicatedPods") {}

        /// <summary>
        /// the name of the account associated with the pod. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list dedicated pods by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return (Guid) Parameters[nameof(AffinityGroupId).ToLower()]; }
            set { Parameters[nameof(AffinityGroupId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain associated with the pod
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the pod
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists dedicated pods.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicatePodResponse> ListDedicatedPods(ListDedicatedPodsRequest request);
        Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAsync(ListDedicatedPodsRequest request);
        ListResponse<DedicatePodResponse> ListDedicatedPodsAllPages(ListDedicatedPodsRequest request);
        Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAllPagesAsync(ListDedicatedPodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicatePodResponse> ListDedicatedPods(ListDedicatedPodsRequest request) => _proxy.Request<ListResponse<DedicatePodResponse>>(request);
        public Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAsync(ListDedicatedPodsRequest request) => _proxy.RequestAsync<ListResponse<DedicatePodResponse>>(request);
        public ListResponse<DedicatePodResponse> ListDedicatedPodsAllPages(ListDedicatedPodsRequest request) => _proxy.RequestAllPages<DedicatePodResponse>(request);
        public Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAllPagesAsync(ListDedicatedPodsRequest request) => _proxy.RequestAllPagesAsync<DedicatePodResponse>(request);
    }
}
