using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reconnects a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReconnectHost(ReconnectHostRequest request);
        Task<AsyncJobResponse> ReconnectHostAsync(ReconnectHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReconnectHost(ReconnectHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReconnectHostAsync(ReconnectHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
