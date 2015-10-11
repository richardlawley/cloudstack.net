using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteServiceOffering(DeleteServiceOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
