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
        public Guid Id { get; set; }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup { get; set; }

    }
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, DHCP servers 2) reapplying all public IPs 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, DHCP servers 2) reapplying all public IPs 3) reapplying loadBalancing/portForwarding rules
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
