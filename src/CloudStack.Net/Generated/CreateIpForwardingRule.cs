using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateIpForwardingRuleRequest : APIRequest
    {
        public CreateIpForwardingRuleRequest() : base("createIpForwardingRule") {}

        /// <summary>
        /// the public IP address ID of the forwarding rule, already associated via associateIp
        /// </summary>
        public Guid IpAddressId { get; set; }

        /// <summary>
        /// the protocol for the rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the start port for the rule
        /// </summary>
        public int StartPort { get; set; }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist { get; set; }

        /// <summary>
        /// the end port for the rule
        /// </summary>
        public int? EndPort { get; set; }

        /// <summary>
        /// if true, firewall rule for source/end pubic port is automatically created; if false - firewall rule has to be created explicitly. Has value true by default
        /// </summary>
        public bool? OpenFirewall { get; set; }

    }
    /// <summary>
    /// Creates an IP forwarding rule
    /// </summary>
    /// <summary>
    /// Creates an IP forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallRuleResponse CreateIpForwardingRule(CreateIpForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallRuleResponse CreateIpForwardingRule(CreateIpForwardingRuleRequest request) => _proxy.Request<FirewallRuleResponse>(request);
    }
}
