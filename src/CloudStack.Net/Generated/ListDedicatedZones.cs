using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedZonesRequest : APIRequest
    {
        public ListDedicatedZonesRequest() : base("listDedicatedZones") {}

        /// <summary>
        /// the name of the account associated with the zone. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list dedicated zones by affinity group
        /// </summary>
        public Guid AffinityGroupId { get; set; }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List dedicated zones.
    /// </summary>
    /// <summary>
    /// List dedicated zones.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateZoneResponse> ListDedicatedZones(ListDedicatedZonesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateZoneResponse> ListDedicatedZones(ListDedicatedZonesRequest request) => _proxy.Request<ListResponse<DedicateZoneResponse>>(request);
    }
}
