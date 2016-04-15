using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestartNetworkRequest : APIRequest
    {
        public RestartNetworkRequest() : base("restartNetwork") {}

        /// <summary>
        /// The ID of the network to restart.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup {
            get { return GetParameterValue<bool?>(nameof(Cleanup).ToLower()); }
            set { SetParameterValue(nameof(Cleanup).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, DHCP servers 2) reapplying all public IPs 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestartNetwork(RestartNetworkRequest request);
        Task<AsyncJobResponse> RestartNetworkAsync(RestartNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestartNetwork(RestartNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestartNetworkAsync(RestartNetworkRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
