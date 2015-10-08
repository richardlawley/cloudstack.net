using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListZonesRequest : APIRequest
    {
        public ListZonesRequest() : base("listZones") {}

        /// <summary>
        /// true if you want to retrieve all available Zones. False if you only want to return the Zones from which you have at least one VM. Default is false.
        /// </summary>
        public bool? Available { get; set; }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the zone
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network type of the zone that the virtual machine belongs to
        /// </summary>
        public string NetworkType { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// flag to display the capacity of the zones
        /// </summary>
        public bool? ShowCapacities { get; set; }

        /// <summary>
        /// List zones by resource tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

    }
    /// <summary>
    /// Lists zones
    /// </summary>
    /// <summary>
    /// Lists zones
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ZoneResponse> ListZones(ListZonesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ZoneResponse> ListZones(ListZonesRequest request) => _proxy.Request<ListResponse<ZoneResponse>>(request);
    }
}
