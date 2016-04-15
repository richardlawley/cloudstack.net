using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteConditionRequest : APIRequest
    {
        public DeleteConditionRequest() : base("deleteCondition") {}

        /// <summary>
        /// the ID of the condition.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a condition
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteCondition(DeleteConditionRequest request);
        Task<AsyncJobResponse> DeleteConditionAsync(DeleteConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteCondition(DeleteConditionRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteConditionAsync(DeleteConditionRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
