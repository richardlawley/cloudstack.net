using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FirewallRuleResponse
    {
        /// <summary>
        /// the ID of the port forwarding rule
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public string CidrList { get; set; }

        /// <summary>
        /// is firewall for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the public ip address for the port forwarding rule
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// the public ip address id for the port forwarding rule
        /// </summary>
        public string Ipaddressid { get; set; }

        /// <summary>
        /// the id of the guest network the port forwarding rule belongs to
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public string PrivateEndPort { get; set; }

        /// <summary>
        /// the starting port of port forwarding rule's private port range
        /// </summary>
        public string Privateport { get; set; }

        /// <summary>
        /// the protocol of the port forwarding rule
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public string PublicEndPort { get; set; }

        /// <summary>
        /// the starting port of port forwarding rule's public port range
        /// </summary>
        public string Publicport { get; set; }

        /// <summary>
        /// the state of the rule
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the VM display name for the port forwarding rule
        /// </summary>
        public string VirtualMachineDisplayName { get; set; }

        /// <summary>
        /// the VM ID for the port forwarding rule
        /// </summary>
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// the VM name for the port forwarding rule
        /// </summary>
        public string VirtualMachineName { get; set; }

        /// <summary>
        /// the vm ip address for the port forwarding rule
        /// </summary>
        public string Vmguestip { get; set; }

        /// <summary>
        /// the list of resource tags associated with the rule
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
