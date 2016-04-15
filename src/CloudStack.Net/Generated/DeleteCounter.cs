using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCounterRequest : APIRequest
    {
        public DeleteCounterRequest() : base("deleteCounter") {}

        /// <summary>
        /// the ID of the counter
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a counter
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteCounter(DeleteCounterRequest request);
        Task<AsyncJobResponse> DeleteCounterAsync(DeleteCounterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteCounter(DeleteCounterRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteCounterAsync(DeleteCounterRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
