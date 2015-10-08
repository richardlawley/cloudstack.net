using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReconnectHostRequest : APIRequest
    {
        public ReconnectHostRequest() : base("reconnectHost") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Reconnects a host.
    /// </summary>
    /// <summary>
    /// Reconnects a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse ReconnectHost(ReconnectHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse ReconnectHost(ReconnectHostRequest request) => _proxy.Request<HostResponse>(request);
    }
}
