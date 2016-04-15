using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBaremetalRctRequest : APIRequest
    {
        public DeleteBaremetalRctRequest() : base("deleteBaremetalRct") {}

        /// <summary>
        /// RCT id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// deletes baremetal rack configuration text
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request);
        Task<AsyncJobResponse> DeleteBaremetalRctAsync(DeleteBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteBaremetalRctAsync(DeleteBaremetalRctRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
