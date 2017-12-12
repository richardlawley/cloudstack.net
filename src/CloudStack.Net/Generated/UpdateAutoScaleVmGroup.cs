using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the group to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int? Interval {
            get { return GetParameterValue<int?>(nameof(Interval).ToLower()); }
            set { SetParameterValue(nameof(Interval).ToLower(), value); }
        }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int? MaxMembers {
            get { return GetParameterValue<int?>(nameof(MaxMembers).ToLower()); }
            set { SetParameterValue(nameof(MaxMembers).ToLower(), value); }
        }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int? MinMembers {
            get { return GetParameterValue<int?>(nameof(MinMembers).ToLower()); }
            set { SetParameterValue(nameof(MinMembers).ToLower(), value); }
        }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<Guid> ScaleDownPolicyIds {
            get { return GetList<Guid>(nameof(ScaleDownPolicyIds).ToLower()); }
            set { SetParameterValue(nameof(ScaleDownPolicyIds).ToLower(), value); }
        }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<Guid> ScaleUpPolicyIds {
            get { return GetList<Guid>(nameof(ScaleUpPolicyIds).ToLower()); }
            set { SetParameterValue(nameof(ScaleUpPolicyIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates an existing autoscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request);
        Task<AsyncJobResponse> UpdateAutoScaleVmGroupAsync(UpdateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScaleVmGroup(UpdateAutoScaleVmGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateAutoScaleVmGroupAsync(UpdateAutoScaleVmGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
