using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListInternalLoadBalancerElementsRequest : APIRequest
    {
        public ListInternalLoadBalancerElementsRequest() : base("listInternalLoadBalancerElements") {}

        /// <summary>
        /// list internal load balancer elements by enabled state
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// list internal load balancer elements by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list internal load balancer elements by network service provider id
        /// </summary>
        public Guid NspId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all available Internal Load Balancer elements.
    /// </summary>
    /// <summary>
    /// Lists all available Internal Load Balancer elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElements(ListInternalLoadBalancerElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElements(ListInternalLoadBalancerElementsRequest request) => _proxy.Request<ListResponse<InternalLoadBalancerElementResponse>>(request);
    }
}
