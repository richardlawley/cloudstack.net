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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePrivateGateway(DeletePrivateGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePrivateGateway(DeletePrivateGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
