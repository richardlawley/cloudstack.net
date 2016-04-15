using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePrivateGateway(DeletePrivateGatewayRequest request);
        Task<AsyncJobResponse> DeletePrivateGatewayAsync(DeletePrivateGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePrivateGateway(DeletePrivateGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeletePrivateGatewayAsync(DeletePrivateGatewayRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
