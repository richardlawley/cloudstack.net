using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAutoScaleVmGroupRequest : APIRequest
    {
        public UpdateAutoScaleVmGroupRequest() : base("updateAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the group to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int? MaxMembers { get; set; }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int? MinMembers { get; set; }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<long> ScaleDownPolicyIds { get; set; }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<long> ScaleUpPolicyIds { get; set; }

    }
    /// <summary>
    /// Updates an existing autoscale vm group.
    /// </summary>
    /// <summary>
    /// Updates an existing autoscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmGroupResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmGroupResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request) => _proxy.Request<AutoScaleVmGroupResponse>(request);
    }
}
