using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedZoneRequest : APIRequest
    {
        public ReleaseDedicatedZoneRequest() : base("releaseDedicatedZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Release dedication of zone
    /// </summary>
    /// <summary>
    /// Release dedication of zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
