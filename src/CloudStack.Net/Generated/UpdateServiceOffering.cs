using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateServiceOfferingRequest : APIRequest
    {
        public UpdateServiceOfferingRequest() : base("updateServiceOffering") {}

        /// <summary>
        /// the ID of the service offering to be updated
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the display text of the service offering to be updated
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the service offering to be updated
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// sort key of the service offering, integer
        /// </summary>
        public int? SortKey { get; set; }

    }
    /// <summary>
    /// Updates a service offering.
    /// </summary>
    /// <summary>
    /// Updates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request) => _proxy.Request<ServiceOfferingResponse>(request);
    }
}
