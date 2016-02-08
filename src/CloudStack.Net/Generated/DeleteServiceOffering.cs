using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteServiceOfferingRequest : APIRequest
    {
        public DeleteServiceOfferingRequest() : base("deleteServiceOffering") {}

        /// <summary>
        /// the ID of the service offering
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteServiceOffering(DeleteServiceOfferingRequest request);
        Task<SuccessResponse> DeleteServiceOfferingAsync(DeleteServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteServiceOffering(DeleteServiceOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteServiceOfferingAsync(DeleteServiceOfferingRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
