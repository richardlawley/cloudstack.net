using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateZoneRequest : APIRequest
    {
        public DedicateZoneRequest() : base("dedicateZone") {}

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

    }
    /// <summary>
    /// Dedicates a zones.
    /// </summary>
    /// <summary>
    /// Dedicates a zones.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DedicateZoneResponse DedicateZone(DedicateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DedicateZoneResponse DedicateZone(DedicateZoneRequest request) => _proxy.Request<DedicateZoneResponse>(request);
    }
}
