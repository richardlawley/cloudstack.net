using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateServiceOfferingRequest : APIRequest
    {
        public UpdateServiceOfferingRequest() : base("updateServiceOffering") {}

        /// <summary>
        /// the ID of the service offering to be updated
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the service offering to be updated
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the service offering to be updated
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the service offering, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request);
        Task<ServiceOfferingResponse> UpdateServiceOfferingAsync(UpdateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request) => _proxy.Request<ServiceOfferingResponse>(request);
        public Task<ServiceOfferingResponse> UpdateServiceOfferingAsync(UpdateServiceOfferingRequest request) => _proxy.RequestAsync<ServiceOfferingResponse>(request);
    }
}
