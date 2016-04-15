using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScalePolicyRequest : APIRequest
    {
        public DeleteAutoScalePolicyRequest() : base("deleteAutoScalePolicy") {}

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a autoscale policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAutoScalePolicy(DeleteAutoScalePolicyRequest request);
        Task<AsyncJobResponse> DeleteAutoScalePolicyAsync(DeleteAutoScalePolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAutoScalePolicy(DeleteAutoScalePolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAutoScalePolicyAsync(DeleteAutoScalePolicyRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
