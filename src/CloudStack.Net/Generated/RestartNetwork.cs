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
        /// The id of the network to restart.
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
    /// Restarts the network; includes 1) restarting network elements - virtual routers, dhcp servers 2) reapplying all public ips 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, dhcp servers 2) reapplying all public ips 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IPAddressResponse RestartNetwork(RestartNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IPAddressResponse RestartNetwork(RestartNetworkRequest request) => _proxy.Request<IPAddressResponse>(request);
    }
}
