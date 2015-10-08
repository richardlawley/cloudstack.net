using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkACLRequest : APIRequest
    {
        public CreateNetworkACLRequest() : base("createNetworkACL") {}

        /// <summary>
        /// the protocol for the ACL rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// The network of the VM the ACL will be created for
        /// </summary>
        public Guid AclId { get; set; }

        /// <summary>
        /// scl entry action, allow or deny
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the CIDR list to allow traffic from/to
        /// </summary>
        public IList<string> Cidrlist { get; set; }

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
        /// The network of the VM the ACL will be created for
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// The network of the VM the ACL will be created for
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// the starting port of ACL
        /// </summary>
        public int? PublicStartPort { get; set; }

        /// <summary>
        /// the traffic type for the ACL,can be ingress or egress, defaulted to ingress if not specified
        /// </summary>
        public string TrafficType { get; set; }

    }
    /// <summary>
    /// Creates a ACL rule in the given network (the network has to belong to VPC)
    /// </summary>
    /// <summary>
    /// Creates a ACL rule in the given network (the network has to belong to VPC)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkACLItemResponse CreateNetworkACL(CreateNetworkACLRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkACLItemResponse CreateNetworkACL(CreateNetworkACLRequest request) => _proxy.Request<NetworkACLItemResponse>(request);
    }
}
