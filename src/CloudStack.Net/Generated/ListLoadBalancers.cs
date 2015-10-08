using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancersRequest : APIRequest
    {
        public ListLoadBalancersRequest() : base("listLoadBalancers") {}

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
        /// the ID of the load balancer
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
        /// the name of the load balancer
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// the network ID of the load balancer
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the scheme of the load balancer. Supported value is internal in the current release
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// the source IP address of the load balancer
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// the network ID of the source IP address
        /// </summary>
        public Guid SourceIpNetworkId { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

    }
    /// <summary>
    /// Lists load balancers
    /// </summary>
    /// <summary>
    /// Lists load balancers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancers(ListLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancers(ListLoadBalancersRequest request) => _proxy.Request<ListResponse<ApplicationLoadBalancerResponse>>(request);
    }
}
