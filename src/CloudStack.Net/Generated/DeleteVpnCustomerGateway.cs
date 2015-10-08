using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVpnCustomerGatewayRequest : APIRequest
    {
        public DeleteVpnCustomerGatewayRequest() : base("deleteVpnCustomerGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Delete site to site vpn customer gateway
    /// </summary>
    /// <summary>
    /// Delete site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
