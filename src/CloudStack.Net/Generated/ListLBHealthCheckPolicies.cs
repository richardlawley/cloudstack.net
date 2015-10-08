using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLBHealthCheckPoliciesRequest : APIRequest
    {
        public ListLBHealthCheckPoliciesRequest() : base("listLBHealthCheckPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the ID of the health check policy
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists load balancer health check policies.
    /// </summary>
    /// <summary>
    /// Lists load balancer health check policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request) => _proxy.Request<ListResponse<LBHealthCheckResponse>>(request);
    }
}
