using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAutoScalePolicyRequest : APIRequest
    {
        public UpdateAutoScalePolicyRequest() : base("updateAutoScalePolicy") {}

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the list of IDs of the conditions that are being evaluated on every interval
        /// </summary>
        public IList<Guid> ConditionIds {
            get { return GetList<Guid>(nameof(ConditionIds).ToLower()); }
            set { Parameters[nameof(ConditionIds).ToLower()] = value; }
        }

        /// <summary>
        /// the duration for which the conditions have to be true before action is taken
        /// </summary>
        public int? Duration {
            get { return (int?) Parameters[nameof(Duration).ToLower()]; }
            set { Parameters[nameof(Duration).ToLower()] = value; }
        }

        /// <summary>
        /// the cool down period for which the policy should not be evaluated after the action has been taken
        /// </summary>
        public int? QuietTime {
            get { return (int?) Parameters[nameof(QuietTime).ToLower()]; }
            set { Parameters[nameof(QuietTime).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates an existing autoscale policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScalePolicy(UpdateAutoScalePolicyRequest request);
        Task<AsyncJobResponse> UpdateAutoScalePolicyAsync(UpdateAutoScalePolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScalePolicy(UpdateAutoScalePolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateAutoScalePolicyAsync(UpdateAutoScalePolicyRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
