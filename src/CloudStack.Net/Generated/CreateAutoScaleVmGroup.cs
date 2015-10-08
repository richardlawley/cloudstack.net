using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAutoScaleVmGroupRequest : APIRequest
    {
        public CreateAutoScaleVmGroupRequest() : base("createAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId { get; set; }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int MaxMembers { get; set; }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int MinMembers { get; set; }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<long> ScaleDownPolicyIds { get; set; }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<long> ScaleUpPolicyIds { get; set; }

        /// <summary>
        /// the autoscale profile that contains information about the vms in the vm group.
        /// </summary>
        public Guid ProfileId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the group to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int? Interval { get; set; }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmGroupResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmGroupResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request) => _proxy.Request<AutoScaleVmGroupResponse>(request);
    }
}
