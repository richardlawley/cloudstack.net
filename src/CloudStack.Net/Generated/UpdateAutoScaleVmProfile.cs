using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid AutoscaleUserId {
            get { return GetParameterValue<Guid>(nameof(AutoscaleUserId).ToLower()); }
            set { SetParameterValue(nameof(AutoscaleUserId).ToLower(), value); }
        }

        /// <summary>
        /// counterparam list. Example: counterparam[0].name=snmpcommunity&counterparam[0].value=public&counterparam[1].name=snmpport&counterparam[1].value=161
        /// </summary>
        public IList<IDictionary<string, object>> Counterparam {
            get { return GetList<IDictionary<string, object>>(nameof(Counterparam).ToLower()); }
            set { SetParameterValue(nameof(Counterparam).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? DestroyVmGraceperiod {
            get { return GetParameterValue<int?>(nameof(DestroyVmGraceperiod).ToLower()); }
            set { SetParameterValue(nameof(DestroyVmGraceperiod).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the profile to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates an existing autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request);
        Task<AsyncJobResponse> UpdateAutoScaleVmProfileAsync(UpdateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateAutoScaleVmProfileAsync(UpdateAutoScaleVmProfileRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
