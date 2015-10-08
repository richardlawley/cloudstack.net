using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStaticRouteRequest : APIRequest
    {
        public CreateStaticRouteRequest() : base("createStaticRoute") {}

        /// <summary>
        /// static route cidr
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the gateway id we are creating static route for
        /// </summary>
        public Guid GatewayId { get; set; }

    }
    /// <summary>
    /// Creates a static route
    /// </summary>
    /// <summary>
    /// Creates a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StaticRouteResponse CreateStaticRoute(CreateStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StaticRouteResponse CreateStaticRoute(CreateStaticRouteRequest request) => _proxy.Request<StaticRouteResponse>(request);
    }
}
