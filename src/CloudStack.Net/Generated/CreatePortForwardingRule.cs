using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePortForwardingRuleRequest : APIRequest
    {
        public CreatePortForwardingRuleRequest() : base("createPortForwardingRule") {}

        /// <summary>
        /// the IP address id of the port forwarding rule
        /// </summary>
        public Guid IpAddressId { get; set; }

        /// <summary>
        /// the starting port of port forwarding rule's private port range
        /// </summary>
        public int PrivateStartPort { get; set; }

        /// <summary>
        /// the protocol for the port forwarding rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the starting port of port forwarding rule's public port range
        /// </summary>
        public int PublicStartPort { get; set; }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the network of the virtual machine the port forwarding rule will be created for. Required when public IP address is not associated with any guest network yet (VPC case).
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitly. If not specified 1) defaulted to false when PF rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall { get; set; }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PrivateEndPort { get; set; }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PublicEndPort { get; set; }

        /// <summary>
        /// VM guest nic secondary IP address for the port forwarding rule
        /// </summary>
        public string VmSecondaryIp { get; set; }

    }
    /// <summary>
    /// Creates a port forwarding rule
    /// </summary>
    /// <summary>
    /// Creates a port forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallRuleResponse CreatePortForwardingRule(CreatePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallRuleResponse CreatePortForwardingRule(CreatePortForwardingRuleRequest request) => _proxy.Request<FirewallRuleResponse>(request);
    }
}
