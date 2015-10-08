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
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid AutoscaleUserId { get; set; }

        /// <summary>
        /// counterparam list. Example: counterparam[0].name=snmpcommunity&counterparam[0].value=public&counterparam[1].name=snmpport&counterparam[1].value=161
        /// </summary>
        public IDictionary<string, string> CounterParamList { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? DestroyVmGraceperiod { get; set; }

        /// <summary>
        /// an optional field, whether to the display the profile to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId { get; set; }

    }
    /// <summary>
    /// Updates an existing autoscale vm profile.
    /// </summary>
    /// <summary>
    /// Updates an existing autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmProfileResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmProfileResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request) => _proxy.Request<AutoScaleVmProfileResponse>(request);
    }
}
