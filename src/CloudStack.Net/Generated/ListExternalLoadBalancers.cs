using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListExternalLoadBalancersRequest : APIRequest
    {
        public ListExternalLoadBalancersRequest() : base("listExternalLoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists F5 external load balancer appliances added in a zone.
    /// </summary>
    /// <summary>
    /// Lists F5 external load balancer appliances added in a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostResponse> ListExternalLoadBalancers(ListExternalLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostResponse> ListExternalLoadBalancers(ListExternalLoadBalancersRequest request) => _proxy.Request<ListResponse<HostResponse>>(request);
    }
}
