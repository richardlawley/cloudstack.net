using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkServiceProviderRequest : APIRequest
    {
        public DeleteNetworkServiceProviderRequest() : base("deleteNetworkServiceProvider") {}

        /// <summary>
        /// the ID of the network service provider
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Network Service Provider.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNetworkServiceProvider(DeleteNetworkServiceProviderRequest request);
        Task<AsyncJobResponse> DeleteNetworkServiceProviderAsync(DeleteNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetworkServiceProvider(DeleteNetworkServiceProviderRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNetworkServiceProviderAsync(DeleteNetworkServiceProviderRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
