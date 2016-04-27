using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the IP address of the Private gateaway
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the Private gateway
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// the network implementation uri for the private gateway
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId {
            get { return GetParameterValue<Guid>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid? AclId {
            get { return GetParameterValue<Guid?>(nameof(AclId).ToLower()); }
            set { SetParameterValue(nameof(AclId).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of the network offering to use for the private gateways network connection
        /// </summary>
        public Guid? NetworkOfferingId {
            get { return GetParameterValue<Guid?>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID the network belongs to
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// source NAT supported value. Default value false. If 'true' source NAT is enabled on the private gateway 'false': sourcenat is not supported
        /// </summary>
        public bool? Sourcenatsupported {
            get { return GetParameterValue<bool?>(nameof(Sourcenatsupported).ToLower()); }
            set { SetParameterValue(nameof(Sourcenatsupported).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreatePrivateGateway(CreatePrivateGatewayRequest request);
        Task<AsyncJobResponse> CreatePrivateGatewayAsync(CreatePrivateGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreatePrivateGateway(CreatePrivateGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreatePrivateGatewayAsync(CreatePrivateGatewayRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
