using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkServiceProviderRequest : APIRequest
    {
        public UpdateNetworkServiceProviderRequest() : base("updateNetworkServiceProvider") {}

        /// <summary>
        /// network service provider id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> Servicelist {
            get { return GetList<string>(nameof(Servicelist).ToLower()); }
            set { SetParameterValue(nameof(Servicelist).ToLower(), value); }
        }

        /// <summary>
        /// Enabled/Disabled/Shutdown the physical network service provider
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a network serviceProvider of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request);
        Task<AsyncJobResponse> UpdateNetworkServiceProviderAsync(UpdateNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateNetworkServiceProviderAsync(UpdateNetworkServiceProviderRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
