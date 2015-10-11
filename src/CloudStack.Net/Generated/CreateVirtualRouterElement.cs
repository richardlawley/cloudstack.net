using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(NspId).ToLower()]; }
            set { Parameters[nameof(NspId).ToLower()] = value; }
        }

        /// <summary>
        /// The provider type. Supported types are VirtualRouter (default) and VPCVirtualRouter
        /// </summary>
        public Guid ProviderType {
            get { return (Guid) Parameters[nameof(ProviderType).ToLower()]; }
            set { Parameters[nameof(ProviderType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Create a virtual router element.
    /// </summary>
    /// <summary>
    /// Create a virtual router element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
