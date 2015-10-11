using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes a condition
    /// </summary>
    /// <summary>
    /// Removes a condition
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteCondition(DeleteConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteCondition(DeleteConditionRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
