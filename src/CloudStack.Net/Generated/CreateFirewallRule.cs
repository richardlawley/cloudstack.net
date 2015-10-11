using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateFirewallRuleRequest : APIRequest
    {
        public CreateFirewallRuleRequest() : base("createFirewallRule") {}

        /// <summary>
        /// the IP address id of the port forwarding rule
        /// </summary>
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

        /// <summary>
        /// the protocol for the firewall rule. Valid values are TCP/UDP/ICMP.
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return (IList<string>) Parameters[nameof(Cidrlist).ToLower()]; }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// the ending port of firewall rule
        /// </summary>
        public int? Endport {
            get { return (int?) Parameters[nameof(Endport).ToLower()]; }
            set { Parameters[nameof(Endport).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode {
            get { return (int?) Parameters[nameof(IcmpCode).ToLower()]; }
            set { Parameters[nameof(IcmpCode).ToLower()] = value; }
        }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int? IcmpType {
            get { return (int?) Parameters[nameof(IcmpType).ToLower()]; }
            set { Parameters[nameof(IcmpType).ToLower()] = value; }
        }

        /// <summary>
        /// the starting port of firewall rule
        /// </summary>
        public int? Startport {
            get { return (int?) Parameters[nameof(Startport).ToLower()]; }
            set { Parameters[nameof(Startport).ToLower()] = value; }
        }

        /// <summary>
        /// type of firewallrule: system/user
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a firewall rule for a given ip address
    /// </summary>
    /// <summary>
    /// Creates a firewall rule for a given ip address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallResponse CreateFirewallRule(CreateFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallResponse CreateFirewallRule(CreateFirewallRuleRequest request) => _proxy.Request<FirewallResponse>(request);
    }
}
