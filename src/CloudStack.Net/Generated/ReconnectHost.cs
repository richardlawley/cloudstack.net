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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Reconnects a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReconnectHost(ReconnectHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReconnectHost(ReconnectHostRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
