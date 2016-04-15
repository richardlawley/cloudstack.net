using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteStaticRoute(DeleteStaticRouteRequest request);
        Task<AsyncJobResponse> DeleteStaticRouteAsync(DeleteStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteStaticRoute(DeleteStaticRouteRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteStaticRouteAsync(DeleteStaticRouteRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
