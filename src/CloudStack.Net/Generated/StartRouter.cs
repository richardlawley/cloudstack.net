using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartRouterRequest : APIRequest
    {
        public StartRouterRequest() : base("startRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Starts a router.
    /// </summary>
    /// <summary>
    /// Starts a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainRouterResponse StartRouter(StartRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse StartRouter(StartRouterRequest request) => _proxy.Request<DomainRouterResponse>(request);
    }
}
