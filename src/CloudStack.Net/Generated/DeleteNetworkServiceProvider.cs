using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Network Service Provider.
    /// </summary>
    /// <summary>
    /// Deletes a Network Service Provider.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNetworkServiceProvider(DeleteNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetworkServiceProvider(DeleteNetworkServiceProviderRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
