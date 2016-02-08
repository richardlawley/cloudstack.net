using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FirewallResponse
    {
        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public string CidrList { get; set; }

        /// <summary>
        /// the ending port of firewall rule's port range
        /// </summary>
        public int EndPort { get; set; }

        /// <summary>
        /// is rule for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int IcmpCode { get; set; }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int IcmpType { get; set; }

        /// <summary>
        /// the public ip address for the firewall rule
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// the public ip address id for the firewall rule
        /// </summary>
        public string Ipaddressid { get; set; }

        /// <summary>
        /// the network id of the firewall rule
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the protocol of the firewall rule
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the starting port of firewall rule's port range
        /// </summary>
        public int StartPort { get; set; }

        /// <summary>
        /// the state of the rule
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the list of resource tags associated with the rule
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
