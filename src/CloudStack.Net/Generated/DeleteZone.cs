using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteZoneRequest : APIRequest
    {
        public DeleteZoneRequest() : base("deleteZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a Zone.
    /// </summary>
    /// <summary>
    /// Deletes a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteZone(DeleteZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteZone(DeleteZoneRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
