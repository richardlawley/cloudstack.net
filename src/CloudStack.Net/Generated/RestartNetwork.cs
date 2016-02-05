using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup {
            get { return (bool?) Parameters[nameof(Cleanup).ToLower()]; }
            set { Parameters[nameof(Cleanup).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, DHCP servers 2) reapplying all public IPs 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestartNetwork(RestartNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestartNetwork(RestartNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
