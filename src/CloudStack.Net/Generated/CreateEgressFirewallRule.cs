using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateEgressFirewallRuleRequest : APIRequest
    {
        public CreateEgressFirewallRuleRequest() : base("createEgressFirewallRule") {}

        /// <summary>
        /// the network id of the port forwarding rule
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// the protocol for the firewall rule. Valid values are TCP/UDP/ICMP.
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist { get; set; }

        /// <summary>
        /// the ending port of firewall rule
        /// </summary>
        public int? PublicEndPort { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode { get; set; }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int? IcmpType { get; set; }

        /// <summary>
        /// the starting port of firewall rule
        /// </summary>
        public int? PublicStartPort { get; set; }

        /// <summary>
        /// type of firewallrule: system/user
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Creates a egress firewall rule for a given network 
    /// </summary>
    /// <summary>
    /// Creates a egress firewall rule for a given network 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallResponse CreateEgressFirewallRule(CreateEgressFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallResponse CreateEgressFirewallRule(CreateEgressFirewallRuleRequest request) => _proxy.Request<FirewallResponse>(request);
    }
}
