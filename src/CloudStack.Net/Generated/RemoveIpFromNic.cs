using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveIpFromNicRequest : APIRequest
    {
        public RemoveIpFromNicRequest() : base("removeIpFromNic") {}

        /// <summary>
        /// the ID of the secondary ip address to nic
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes secondary IP from the NIC.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveIpFromNic(RemoveIpFromNicRequest request);
        Task<AsyncJobResponse> RemoveIpFromNicAsync(RemoveIpFromNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveIpFromNic(RemoveIpFromNicRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveIpFromNicAsync(RemoveIpFromNicRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
