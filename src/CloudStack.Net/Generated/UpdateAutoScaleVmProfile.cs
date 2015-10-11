using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAutoScaleVmProfileRequest : APIRequest
    {
        public UpdateAutoScaleVmProfileRequest() : base("updateAutoScaleVmProfile") {}

        /// <summary>
        /// the ID of the autoscale vm profile
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid AutoscaleUserId {
            get { return (Guid) Parameters[nameof(AutoscaleUserId).ToLower()]; }
            set { Parameters[nameof(AutoscaleUserId).ToLower()] = value; }
        }

        /// <summary>
        /// counterparam list. Example: counterparam[0].name=snmpcommunity&counterparam[0].value=public&counterparam[1].name=snmpport&counterparam[1].value=161
        /// </summary>
        public IList<IDictionary<string, object>> Counterparam {
            get { return GetList<IDictionary<string, object>>(nameof(Counterparam).ToLower()); }
            set { Parameters[nameof(Counterparam).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? DestroyVmGraceperiod {
            get { return (int?) Parameters[nameof(DestroyVmGraceperiod).ToLower()]; }
            set { Parameters[nameof(DestroyVmGraceperiod).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the profile to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates an existing autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
