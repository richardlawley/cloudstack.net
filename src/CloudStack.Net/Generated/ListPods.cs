using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPodsRequest : APIListRequest
    {
        public ListPodsRequest() : base("listPods") {}

        /// <summary>
        /// list pods by allocation state
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// list Pods by ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// list Pods by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the capacity of the pods
        /// </summary>
        public bool? ShowCapacities {
            get { return GetParameterValue<bool?>(nameof(ShowCapacities).ToLower()); }
            set { SetParameterValue(nameof(ShowCapacities).ToLower(), value); }
        }

        /// <summary>
        /// list Pods by Zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all Pods.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PodResponse> ListPods(ListPodsRequest request);
        Task<ListResponse<PodResponse>> ListPodsAsync(ListPodsRequest request);
        ListResponse<PodResponse> ListPodsAllPages(ListPodsRequest request);
        Task<ListResponse<PodResponse>> ListPodsAllPagesAsync(ListPodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PodResponse> ListPods(ListPodsRequest request) => _proxy.Request<ListResponse<PodResponse>>(request);
        public Task<ListResponse<PodResponse>> ListPodsAsync(ListPodsRequest request) => _proxy.RequestAsync<ListResponse<PodResponse>>(request);
        public ListResponse<PodResponse> ListPodsAllPages(ListPodsRequest request) => _proxy.RequestAllPages<PodResponse>(request);
        public Task<ListResponse<PodResponse>> ListPodsAllPagesAsync(ListPodsRequest request) => _proxy.RequestAllPagesAsync<PodResponse>(request);
    }
}
