using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkACLItemRequest : APIRequest
    {
        public UpdateNetworkACLItemRequest() : base("updateNetworkACLItem") {}

        /// <summary>
        /// the ID of the network ACL item
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// scl entry action, allow or deny
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the cidr list to allow traffic from/to
        /// </summary>
        public IList<string> Cidrlist { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// the ending port of ACL
        /// </summary>
        public int? PublicEndPort { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// error code for this ICMP message
        /// </summary>
        public int? IcmpCode { get; set; }

        /// <summary>
        /// type of the ICMP message being sent
        /// </summary>
        public int? IcmpType { get; set; }

        /// <summary>
        /// The network of the vm the ACL will be created for
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// the protocol for the ACL rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the starting port of ACL
        /// </summary>
        public int? PublicStartPort { get; set; }

        /// <summary>
        /// the traffic type for the ACL,can be Ingress or Egress, defaulted to Ingress if not specified
        /// </summary>
        public string TrafficType { get; set; }

    }
    /// <summary>
    /// Updates ACL item with specified ID
    /// </summary>
    /// <summary>
    /// Updates ACL item with specified ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkACLItemResponse UpdateNetworkACLItem(UpdateNetworkACLItemRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkACLItemResponse UpdateNetworkACLItem(UpdateNetworkACLItemRequest request) => _proxy.Request<NetworkACLItemResponse>(request);
    }
}
