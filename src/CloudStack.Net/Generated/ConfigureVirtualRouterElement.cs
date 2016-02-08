using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureVirtualRouterElementRequest : APIRequest
    {
        public ConfigureVirtualRouterElementRequest() : base("configureVirtualRouterElement") {}

        /// <summary>
        /// the ID of the virtual router provider
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled {
            get { return (bool) Parameters[nameof(Enabled).ToLower()]; }
            set { Parameters[nameof(Enabled).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Configures a virtual router element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureVirtualRouterElement(ConfigureVirtualRouterElementRequest request);
        Task<AsyncJobResponse> ConfigureVirtualRouterElementAsync(ConfigureVirtualRouterElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureVirtualRouterElement(ConfigureVirtualRouterElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureVirtualRouterElementAsync(ConfigureVirtualRouterElementRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
