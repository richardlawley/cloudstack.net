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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
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

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int? MaxMembers {
            get { return (int?) Parameters[nameof(MaxMembers).ToLower()]; }
            set { Parameters[nameof(MaxMembers).ToLower()] = value; }
        }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int? MinMembers {
            get { return (int?) Parameters[nameof(MinMembers).ToLower()]; }
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

    }
    /// <summary>
    /// Updates an existing autoscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
