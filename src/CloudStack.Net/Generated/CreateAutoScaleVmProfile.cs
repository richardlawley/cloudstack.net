using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// availability zone for the auto deployed virtual machine
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid? AutoscaleUserId {
            get { return GetParameterValue<Guid?>(nameof(AutoscaleUserId).ToLower()); }
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
        /// parameters other than zoneId/serviceOfferringId/templateId of the auto deployed virtual machine
        /// </summary>
        public string OtherDeployParams {
            get { return GetParameterValue<string>(nameof(OtherDeployParams).ToLower()); }
            set { SetParameterValue(nameof(OtherDeployParams).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a profile that contains information about the virtual machine which will be provisioned automatically by autoscale feature.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request);
        Task<AsyncJobResponse> CreateAutoScaleVmProfileAsync(CreateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAutoScaleVmProfile(CreateAutoScaleVmProfileRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateAutoScaleVmProfileAsync(CreateAutoScaleVmProfileRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
