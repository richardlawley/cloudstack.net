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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> Servicelist {
            get { return GetList<string>(nameof(Servicelist).ToLower()); }
            set { Parameters[nameof(Servicelist).ToLower()] = value; }
        }

        /// <summary>
        /// Enabled/Disabled/Shutdown the physical network service provider
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a network serviceProvider of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetworkServiceProvider(UpdateNetworkServiceProviderRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
