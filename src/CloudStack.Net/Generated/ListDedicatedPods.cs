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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list dedicated pods by affinity group
        /// </summary>
        public Guid? AffinityGroupId {
            get { return GetParameterValue<Guid?>(nameof(AffinityGroupId).ToLower()); }
            set { SetParameterValue(nameof(AffinityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain associated with the pod
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the pod
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
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
        public ListResponse<DedicatePodResponse> ListDedicatedPods(ListDedicatedPodsRequest request) => Proxy.Request<ListResponse<DedicatePodResponse>>(request);
        public Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAsync(ListDedicatedPodsRequest request) => Proxy.RequestAsync<ListResponse<DedicatePodResponse>>(request);
        public ListResponse<DedicatePodResponse> ListDedicatedPodsAllPages(ListDedicatedPodsRequest request) => Proxy.RequestAllPages<DedicatePodResponse>(request);
        public Task<ListResponse<DedicatePodResponse>> ListDedicatedPodsAllPagesAsync(ListDedicatedPodsRequest request) => Proxy.RequestAllPagesAsync<DedicatePodResponse>(request);
    }
}
