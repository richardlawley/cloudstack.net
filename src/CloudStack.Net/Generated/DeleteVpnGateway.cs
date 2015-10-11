using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVpnGatewayRequest : APIRequest
    {
        public DeleteVpnGatewayRequest() : base("deleteVpnGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Delete site to site vpn gateway
    /// </summary>
    /// <summary>
    /// Delete site to site vpn gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVpnGateway(DeleteVpnGatewayRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
