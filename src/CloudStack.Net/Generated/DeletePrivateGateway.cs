using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePrivateGatewayRequest : APIRequest
    {
        public DeletePrivateGatewayRequest() : base("deletePrivateGateway") {}

        /// <summary>
        /// the ID of the private gateway
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a Private gateway
    /// </summary>
    /// <summary>
    /// Deletes a Private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeletePrivateGateway(DeletePrivateGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeletePrivateGateway(DeletePrivateGatewayRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
