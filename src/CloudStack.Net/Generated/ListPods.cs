using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPodsRequest : APIRequest
    {
        public ListPodsRequest() : base("listPods") {}

        /// <summary>
        /// list pods by allocation state
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// list Pods by ID
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
        /// list Pods by name
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
        /// flag to display the capacity of the pods
        /// </summary>
        public bool? ShowCapacities {
            get { return (bool?) Parameters[nameof(ShowCapacities).ToLower()]; }
            set { Parameters[nameof(ShowCapacities).ToLower()] = value; }
        }

        /// <summary>
        /// list Pods by Zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all Pods.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PodResponse> ListPods(ListPodsRequest request);
        Task<ListResponse<PodResponse>> ListPodsAsync(ListPodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PodResponse> ListPods(ListPodsRequest request) => _proxy.Request<ListResponse<PodResponse>>(request);
        public Task<ListResponse<PodResponse>> ListPodsAsync(ListPodsRequest request) => _proxy.RequestAsync<ListResponse<PodResponse>>(request);
    }
}
