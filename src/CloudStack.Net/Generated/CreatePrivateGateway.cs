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
        public string Gateway { get; set; }

        /// <summary>
        /// the IP address of the Private gateaway
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the netmask of the Private gateway
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the network implementation uri for the private gateway
        /// </summary>
        public string BroadcastUri { get; set; }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid AclId { get; set; }

        /// <summary>
        /// the uuid of the network offering to use for the private gateways network connection
        /// </summary>
        public Guid NetworkOfferingId { get; set; }

        /// <summary>
        /// the Physical Network ID the network belongs to
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// source NAT supported value. Default value false. If 'true' source NAT is enabled on the private gateway 'false': sourcenat is not supported
        /// </summary>
        public bool? IsSourceNat { get; set; }

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
