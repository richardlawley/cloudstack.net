using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePrivateGatewayRequest : APIRequest
    {
        public CreatePrivateGatewayRequest() : base("createPrivateGateway") {}

        /// <summary>
        /// the gateway of the Private gateway
        /// </summary>
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the IP address of the Private gateaway
        /// </summary>
        public string IpAddress {
            get { return (string) Parameters[nameof(IpAddress).ToLower()]; }
            set { Parameters[nameof(IpAddress).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask of the Private gateway
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// the network implementation uri for the private gateway
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid AclId {
            get { return (Guid) Parameters[nameof(AclId).ToLower()]; }
            set { Parameters[nameof(AclId).ToLower()] = value; }
        }

        /// <summary>
        /// the uuid of the network offering to use for the private gateways network connection
        /// </summary>
        public Guid NetworkOfferingId {
            get { return (Guid) Parameters[nameof(NetworkOfferingId).ToLower()]; }
            set { Parameters[nameof(NetworkOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID the network belongs to
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// source NAT supported value. Default value false. If 'true' source NAT is enabled on the private gateway 'false': sourcenat is not supported
        /// </summary>
        public bool? Sourcenatsupported {
            get { return (bool?) Parameters[nameof(Sourcenatsupported).ToLower()]; }
            set { Parameters[nameof(Sourcenatsupported).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a private gateway
    /// </summary>
    /// <summary>
    /// Creates a private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PrivateGatewayResponse CreatePrivateGateway(CreatePrivateGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PrivateGatewayResponse CreatePrivateGateway(CreatePrivateGatewayRequest request) => _proxy.Request<PrivateGatewayResponse>(request);
    }
}
