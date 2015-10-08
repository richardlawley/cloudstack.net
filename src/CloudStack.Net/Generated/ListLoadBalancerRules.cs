using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancerRulesRequest : APIRequest
    {
        public ListLoadBalancerRulesRequest() : base("listLoadBalancerRules") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// the name of the load balancer rule
        /// </summary>
        public string LoadBalancerRuleName { get; set; }

        /// <summary>
        /// list by network ID the rule belongs to
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the public IP address ID of the load balancer rule
        /// </summary>
        public Guid PublicIpId { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// the ID of the virtual machine of the load balancer rule
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists load balancer rules.
    /// </summary>
    /// <summary>
    /// Lists load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LoadBalancerResponse> ListLoadBalancerRules(ListLoadBalancerRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LoadBalancerResponse> ListLoadBalancerRules(ListLoadBalancerRulesRequest request) => _proxy.Request<ListResponse<LoadBalancerResponse>>(request);
    }
}
