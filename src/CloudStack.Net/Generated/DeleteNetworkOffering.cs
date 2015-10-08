using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkOfferingRequest : APIRequest
    {
        public DeleteNetworkOfferingRequest() : base("deleteNetworkOffering") {}

        /// <summary>
        /// the ID of the network offering
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a network offering.
    /// </summary>
    /// <summary>
    /// Deletes a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetworkOffering(DeleteNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkOffering(DeleteNetworkOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
