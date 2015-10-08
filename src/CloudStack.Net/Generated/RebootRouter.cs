using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootRouterRequest : APIRequest
    {
        public RebootRouterRequest() : base("rebootRouter") {}

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
        DomainRouterResponse RebootRouter(RebootRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse RebootRouter(RebootRouterRequest request) => _proxy.Request<DomainRouterResponse>(request);
    }
}
