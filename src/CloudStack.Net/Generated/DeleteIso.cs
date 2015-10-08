using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteIsoRequest : APIRequest
    {
        public DeleteIsoRequest() : base("deleteIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of the zone of the ISO file. If not specified, the ISO will be deleted from all the zones
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Deletes an ISO file.
    /// </summary>
    /// <summary>
    /// Deletes an ISO file.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteIso(DeleteIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteIso(DeleteIsoRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
