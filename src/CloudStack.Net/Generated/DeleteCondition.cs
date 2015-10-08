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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Removes a condition
    /// </summary>
    /// <summary>
    /// Removes a condition
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCondition(DeleteConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCondition(DeleteConditionRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
