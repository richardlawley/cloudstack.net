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
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int MaxMembers {
            get { return (int) Parameters[nameof(MaxMembers).ToLower()]; }
            set { Parameters[nameof(MaxMembers).ToLower()] = value; }
        }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int MinMembers {
            get { return (int) Parameters[nameof(MinMembers).ToLower()]; }
            set { Parameters[nameof(MinMembers).ToLower()] = value; }
        }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<Guid> ScaleDownPolicyIds {
            get { return (IList<Guid>) Parameters[nameof(ScaleDownPolicyIds).ToLower()]; }
            set { Parameters[nameof(ScaleDownPolicyIds).ToLower()] = value; }
        }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<Guid> ScaleUpPolicyIds {
            get { return (IList<Guid>) Parameters[nameof(ScaleUpPolicyIds).ToLower()]; }
            set { Parameters[nameof(ScaleUpPolicyIds).ToLower()] = value; }
        }

        /// <summary>
        /// the autoscale profile that contains information about the vms in the vm group.
        /// </summary>
        public Guid Vmprofileid {
            get { return (Guid) Parameters[nameof(Vmprofileid).ToLower()]; }
            set { Parameters[nameof(Vmprofileid).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the group to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int? Interval {
            get { return (int?) Parameters[nameof(Interval).ToLower()]; }
            set { Parameters[nameof(Interval).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
