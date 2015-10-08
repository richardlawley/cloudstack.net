using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAutoScalePolicyRequest : APIRequest
    {
        public UpdateAutoScalePolicyRequest() : base("updateAutoScalePolicy") {}

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list of IDs of the conditions that are being evaluated on every interval
        /// </summary>
        public IList<long> ConditionIds { get; set; }

        /// <summary>
        /// the duration for which the conditions have to be true before action is taken
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// the cool down period for which the policy should not be evaluated after the action has been taken
        /// </summary>
        public int? QuietTime { get; set; }

    }
    /// <summary>
    /// Updates an existing autoscale policy.
    /// </summary>
    /// <summary>
    /// Updates an existing autoscale policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScalePolicyResponse UpdateAutoScalePolicy(UpdateAutoScalePolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScalePolicyResponse UpdateAutoScalePolicy(UpdateAutoScalePolicyRequest request) => _proxy.Request<AutoScalePolicyResponse>(request);
    }
}
