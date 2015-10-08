using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedPodsRequest : APIRequest
    {
        public ListDedicatedPodsRequest() : base("listDedicatedPods") {}

        /// <summary>
        /// the name of the account associated with the pod. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list dedicated pods by affinity group
        /// </summary>
        public Guid AffinityGroupId { get; set; }

        /// <summary>
        /// the ID of the domain associated with the pod
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the ID of the pod
        /// </summary>
        public Guid PodId { get; set; }

    }
    /// <summary>
    /// Lists dedicated pods.
    /// </summary>
    /// <summary>
    /// Lists dedicated pods.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicatePodResponse> ListDedicatedPods(ListDedicatedPodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicatePodResponse> ListDedicatedPods(ListDedicatedPodsRequest request) => _proxy.Request<ListResponse<DedicatePodResponse>>(request);
    }
}
