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
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// The network of the vm the ACL will be created for
        /// </summary>
        public Guid AclId {
            get { return (Guid) Parameters[nameof(AclId).ToLower()]; }
            set { Parameters[nameof(AclId).ToLower()] = value; }
        }

        /// <summary>
        /// scl entry action, allow or deny
        /// </summary>
        public string Action {
            get { return (string) Parameters[nameof(Action).ToLower()]; }
            set { Parameters[nameof(Action).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list to allow traffic from/to
        /// </summary>
        public IList<string> Cidrlist {
            get { return (IList<string>) Parameters[nameof(Cidrlist).ToLower()]; }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// the ending port of ACL
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
        /// The network of the vm the ACL will be created for
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// The network of the vm the ACL will be created for
        /// </summary>
        public int? Number {
            get { return (int?) Parameters[nameof(Number).ToLower()]; }
            set { Parameters[nameof(Number).ToLower()] = value; }
        }

        /// <summary>
        /// the starting port of ACL
        /// </summary>
        public int? Startport {
            get { return (int?) Parameters[nameof(Startport).ToLower()]; }
            set { Parameters[nameof(Startport).ToLower()] = value; }
        }

        /// <summary>
        /// the traffic type for the ACL,can be Ingress or Egress, defaulted to Ingress if not specified
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

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
