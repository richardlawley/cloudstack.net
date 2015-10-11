using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyRouterRequest : APIRequest
    {
        public DestroyRouterRequest() : base("destroyRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Destroys a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroyRouter(DestroyRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroyRouter(DestroyRouterRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
