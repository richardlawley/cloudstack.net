using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete site to site vpn gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);
        Task<AsyncJobResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVpnGateway(DeleteVpnGatewayRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
