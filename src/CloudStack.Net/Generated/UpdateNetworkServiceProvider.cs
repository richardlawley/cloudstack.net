using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkServiceProviderRequest : APIRequest
    {
        public UpdateNetworkServiceProviderRequest() : base("updateNetworkServiceProvider") {}

        /// <summary>
        /// network service provider id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> EnabledServices { get; set; }

        /// <summary>
        /// Enabled/Disabled/Shutdown the physical network service provider
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Updates a network serviceProvider of a physical network
    /// </summary>
    /// <summary>
    /// Updates a network serviceProvider of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProviderResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProviderResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request) => _proxy.Request<ProviderResponse>(request);
    }
}
