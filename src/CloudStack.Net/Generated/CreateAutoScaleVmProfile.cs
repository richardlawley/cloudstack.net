using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAutoScaleVmProfileRequest : APIRequest
    {
        public CreateAutoScaleVmProfileRequest() : base("createAutoScaleVmProfile") {}

        /// <summary>
        /// the service offering of the auto deployed virtual machine
        /// </summary>
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// availability zone for the auto deployed virtual machine
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid AutoscaleUserId { get; set; }

        /// <summary>
        /// counterparam list. Example: counterparam[0].name=snmpcommunity&counterparam[0].value=public&counterparam[1].name=snmpport&counterparam[1].value=161
        /// </summary>
        public IDictionary<string, string> CounterParamList { get; set; }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? DestroyVmGraceperiod { get; set; }

        /// <summary>
        /// an optional field, whether to the display the profile to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// parameters other than zoneId/serviceOfferringId/templateId of the auto deployed virtual machine
        /// </summary>
        public string OtherDeployParams { get; set; }

    }
    /// <summary>
    /// Creates a profile that contains information about the virtual machine which will be provisioned automatically by autoscale feature.
    /// </summary>
    /// <summary>
    /// Creates a profile that contains information about the virtual machine which will be provisioned automatically by autoscale feature.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmProfileResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmProfileResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request) => _proxy.Request<AutoScaleVmProfileResponse>(request);
    }
}
