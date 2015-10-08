using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetworkServiceProviderRequest : APIRequest
    {
        public AddNetworkServiceProviderRequest() : base("addNetworkServiceProvider") {}

        /// <summary>
        /// the name for the physical network service provider
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the Physical Network ID to add the provider to
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the destination Physical Network ID to bridge to
        /// </summary>
        public Guid DestinationPhysicalNetworkId { get; set; }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> EnabledServices { get; set; }

    }
    /// <summary>
    /// Adds a network serviceProvider to a physical network
    /// </summary>
    /// <summary>
    /// Adds a network serviceProvider to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProviderResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProviderResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request) => _proxy.Request<ProviderResponse>(request);
    }
}
