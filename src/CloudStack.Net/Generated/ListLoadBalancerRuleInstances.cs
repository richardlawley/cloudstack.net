using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancerRuleInstancesRequest : APIRequest
    {
        public ListLoadBalancerRuleInstancesRequest() : base("listLoadBalancerRuleInstances") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// true if listing all virtual machines currently applied to the load balancer rule; default is true
        /// </summary>
        public bool? Applied { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// true if load balancer rule VM IP information to be included; default is false
        /// </summary>
        public bool? IsListLbVmip { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List all virtual machine instances that are assigned to a load balancer rule.
    /// </summary>
    /// <summary>
    /// List all virtual machine instances that are assigned to a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request) => _proxy.Request<ListResponse<LoadBalancerRuleVmMapResponse>>(request);
    }
}
