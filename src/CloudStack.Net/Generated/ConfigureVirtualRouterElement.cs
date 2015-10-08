using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureVirtualRouterElementRequest : APIRequest
    {
        public ConfigureVirtualRouterElementRequest() : base("configureVirtualRouterElement") {}

        /// <summary>
        /// the ID of the virtual router provider
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled { get; set; }

    }
    /// <summary>
    /// Configures a virtual router element.
    /// </summary>
    /// <summary>
    /// Configures a virtual router element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VirtualRouterProviderResponse ConfigureVirtualRouterElement(ConfigureVirtualRouterElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VirtualRouterProviderResponse ConfigureVirtualRouterElement(ConfigureVirtualRouterElementRequest request) => _proxy.Request<VirtualRouterProviderResponse>(request);
    }
}
