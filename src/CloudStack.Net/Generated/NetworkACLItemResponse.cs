using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetworkACLItemResponse
    {
        /// <summary>
        /// the ID of the ACL Item
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the ID of the ACL this item belongs to
        /// </summary>
        public string AclId { get; set; }

        /// <summary>
        /// Action of ACL Item. Allow/Deny
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public string CidrList { get; set; }

        /// <summary>
        /// the ending port of ACL's port range
        /// </summary>
        public string EndPort { get; set; }

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
        /// Number of the ACL Item
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// the protocol of the ACL
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the starting port of ACL's port range
        /// </summary>
        public string StartPort { get; set; }

        /// <summary>
        /// the state of the rule
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the traffic type for the ACL
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// the list of resource tags associated with the network ACLs
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
