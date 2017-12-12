using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStaticRouteRequest : APIRequest
    {
        public CreateStaticRouteRequest() : base("createStaticRoute") {}

        /// <summary>
        /// static route cidr
        /// </summary>
        public string Cidr {
            get { return GetParameterValue<string>(nameof(Cidr).ToLower()); }
            set { SetParameterValue(nameof(Cidr).ToLower(), value); }
        }

        /// <summary>
        /// the gateway id we are creating static route for
        /// </summary>
        public Guid GatewayId {
            get { return GetParameterValue<Guid>(nameof(GatewayId).ToLower()); }
            set { SetParameterValue(nameof(GatewayId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateStaticRoute(CreateStaticRouteRequest request);
        Task<AsyncJobResponse> CreateStaticRouteAsync(CreateStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateStaticRoute(CreateStaticRouteRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateStaticRouteAsync(CreateStaticRouteRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
