using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVPCOfferingRequest : APIRequest
    {
        public UpdateVPCOfferingRequest() : base("updateVPCOffering") {}

        /// <summary>
        /// the id of the VPC offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the VPC offering
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the VPC offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// update state for the VPC offering; supported states - Enabled/Disabled
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVPCOffering(UpdateVPCOfferingRequest request);
        Task<AsyncJobResponse> UpdateVPCOfferingAsync(UpdateVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVPCOffering(UpdateVPCOfferingRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateVPCOfferingAsync(UpdateVPCOfferingRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
