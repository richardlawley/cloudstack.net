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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Starts a router.
    /// </summary>
    /// <summary>
    /// Starts a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartRouter(StartRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartRouter(StartRouterRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
