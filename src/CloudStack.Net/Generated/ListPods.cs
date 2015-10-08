using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPodsRequest : APIRequest
    {
        public ListPodsRequest() : base("listPods") {}

        /// <summary>
        /// list pods by allocation state
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// list Pods by ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list Pods by name
        /// </summary>
        public string PodName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// flag to display the capacity of the pods
        /// </summary>
        public bool? ShowCapacities { get; set; }

        /// <summary>
        /// list Pods by Zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all Pods.
    /// </summary>
    /// <summary>
    /// Lists all Pods.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PodResponse> ListPods(ListPodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PodResponse> ListPods(ListPodsRequest request) => _proxy.Request<ListResponse<PodResponse>>(request);
    }
}
