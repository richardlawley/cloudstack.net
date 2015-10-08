using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVPCOfferingRequest : APIRequest
    {
        public DeleteVPCOfferingRequest() : base("deleteVPCOffering") {}

        /// <summary>
        /// the ID of the VPC offering
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes VPC offering
    /// </summary>
    /// <summary>
    /// Deletes VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVPCOffering(DeleteVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVPCOffering(DeleteVPCOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
