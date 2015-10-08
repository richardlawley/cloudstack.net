using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListEgressFirewallRulesRequest : APIRequest
    {
        public ListEgressFirewallRulesRequest() : base("listEgressFirewallRules") {}

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
        /// Lists rule with the specified ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of IP address of the firewall services
        /// </summary>
        public Guid IpAddressId { get; set; }

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
        /// the network ID for the egress firewall services
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

    }
    /// <summary>
    /// Lists all egress firewall rules for network ID.
    /// </summary>
    /// <summary>
    /// Lists all egress firewall rules for network ID.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<FirewallResponse> ListEgressFirewallRules(ListEgressFirewallRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<FirewallResponse> ListEgressFirewallRules(ListEgressFirewallRulesRequest request) => _proxy.Request<ListResponse<FirewallResponse>>(request);
    }
}
