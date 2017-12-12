using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnGatewayRequest : APIRequest
    {
        public CreateVpnGatewayRequest() : base("createVpnGateway") {}

        /// <summary>
        /// public ip address id of the vpn gateway
        /// </summary>
        public Guid VpcId {
            get { return GetParameterValue<Guid>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates site to site vpn local gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVpnGateway(CreateVpnGatewayRequest request);
        Task<AsyncJobResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVpnGateway(CreateVpnGatewayRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
