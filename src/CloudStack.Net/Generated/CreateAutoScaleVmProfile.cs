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
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

        /// <summary>
        /// availability zone for the auto deployed virtual machine
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
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
        public IDictionary<string, string> Counterparam {
            get { return (IDictionary<string, string>) Parameters[nameof(Counterparam).ToLower()]; }
            set { Parameters[nameof(Counterparam).ToLower()] = value; }
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
        /// parameters other than zoneId/serviceOfferringId/templateId of the auto deployed virtual machine
        /// </summary>
        public string OtherDeployParams {
            get { return (string) Parameters[nameof(OtherDeployParams).ToLower()]; }
            set { Parameters[nameof(OtherDeployParams).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a profile that contains information about the virtual machine which will be provisioned automatically by autoscale feature.
    /// </summary>
    /// <summary>
    /// Creates a profile that contains information about the virtual machine which will be provisioned automatically by autoscale feature.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
