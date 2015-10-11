using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStaticRouteRequest : APIRequest
    {
        public DeleteStaticRouteRequest() : base("deleteStaticRoute") {}

        /// <summary>
        /// the ID of the static route
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteStaticRoute(DeleteStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteStaticRoute(DeleteStaticRouteRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
