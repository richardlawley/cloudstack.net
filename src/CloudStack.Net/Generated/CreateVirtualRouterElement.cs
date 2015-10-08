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
        public Guid NspId { get; set; }

        /// <summary>
        /// The provider type. Supported types are VirtualRouter (default) and VPCVirtualRouter
        /// </summary>
        public Guid ProviderType { get; set; }

    }
    /// <summary>
    /// Create a virtual router element.
    /// </summary>
    /// <summary>
    /// Create a virtual router element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VirtualRouterProviderResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VirtualRouterProviderResponse CreateVirtualRouterElement(CreateVirtualRouterElementRequest request) => _proxy.Request<VirtualRouterProviderResponse>(request);
    }
}
