using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetworkServiceProviderRequest : APIRequest
    {
        public AddNetworkServiceProviderRequest() : base("addNetworkServiceProvider") {}

        /// <summary>
        /// the name for the physical network service provider
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID to add the provider to
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the destination Physical Network ID to bridge to
        /// </summary>
        public Guid? DestinationPhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(DestinationPhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(DestinationPhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> Servicelist {
            get { return GetList<string>(nameof(Servicelist).ToLower()); }
            set { SetParameterValue(nameof(Servicelist).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a network serviceProvider to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request);
        Task<AsyncJobResponse> AddNetworkServiceProviderAsync(AddNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNetworkServiceProviderAsync(AddNetworkServiceProviderRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
