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
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

        /// <summary>
        /// the starting port of port forwarding rule's private port range
        /// </summary>
        public int Privateport {
            get { return (int) Parameters[nameof(Privateport).ToLower()]; }
            set { Parameters[nameof(Privateport).ToLower()] = value; }
        }

        /// <summary>
        /// the protocol for the port fowarding rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the starting port of port forwarding rule's public port range
        /// </summary>
        public int Publicport {
            get { return (int) Parameters[nameof(Publicport).ToLower()]; }
            set { Parameters[nameof(Publicport).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return (IList<string>) Parameters[nameof(Cidrlist).ToLower()]; }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the network of the virtual machine the port forwarding rule will be created for. Required when public IP address is not associated with any guest network yet (VPC case).
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitly. If not specified 1) defaulted to false when PF rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall {
            get { return (bool?) Parameters[nameof(OpenFirewall).ToLower()]; }
            set { Parameters[nameof(OpenFirewall).ToLower()] = value; }
        }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PrivateEndPort {
            get { return (int?) Parameters[nameof(PrivateEndPort).ToLower()]; }
            set { Parameters[nameof(PrivateEndPort).ToLower()] = value; }
        }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PublicEndPort {
            get { return (int?) Parameters[nameof(PublicEndPort).ToLower()]; }
            set { Parameters[nameof(PublicEndPort).ToLower()] = value; }
        }

        /// <summary>
        /// VM guest nic secondary IP address for the port forwarding rule
        /// </summary>
        public string Vmguestip {
            get { return (string) Parameters[nameof(Vmguestip).ToLower()]; }
            set { Parameters[nameof(Vmguestip).ToLower()] = value; }
        }

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
