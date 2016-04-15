using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Starts a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartRouter(StartRouterRequest request);
        Task<AsyncJobResponse> StartRouterAsync(StartRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartRouter(StartRouterRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StartRouterAsync(StartRouterRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
