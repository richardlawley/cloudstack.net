using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVirtualRouterElementRequest : APIRequest
    {
        public CreateVirtualRouterElementRequest() : base("createVirtualRouterElement") {}

        /// <summary>
        /// the network service provider ID of the virtual router element
        /// </summary>
        public Guid NspId {
            get { return GetParameterValue<Guid>(nameof(NspId).ToLower()); }
            set { SetParameterValue(nameof(NspId).ToLower(), value); }
        }

        /// <summary>
        /// The provider type. Supported types are VirtualRouter (default) and VPCVirtualRouter
        /// </summary>
        public Guid ProviderType {
            get { return GetParameterValue<Guid>(nameof(ProviderType).ToLower()); }
            set { SetParameterValue(nameof(ProviderType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a virtual router element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request);
        Task<AsyncJobResponse> CreateVirtualRouterElementAsync(CreateVirtualRouterElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVirtualRouterElementAsync(CreateVirtualRouterElementRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
