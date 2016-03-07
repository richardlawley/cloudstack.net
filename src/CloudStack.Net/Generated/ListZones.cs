using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListZonesRequest : APIListRequest
    {
        public ListZonesRequest() : base("listZones") {}

        /// <summary>
        /// true if you want to retrieve all available Zones. False if you only want to return the Zones from which you have at least one VM. Default is false.
        /// </summary>
        public bool? Available {
            get { return (bool?) Parameters[nameof(Available).ToLower()]; }
            set { Parameters[nameof(Available).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the zone
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the network type of the zone that the virtual machine belongs to
        /// </summary>
        public string NetworkType {
            get { return (string) Parameters[nameof(NetworkType).ToLower()]; }
            set { Parameters[nameof(NetworkType).ToLower()] = value; }
        }

        /// <summary>
        /// flag to display the capacity of the zones
        /// </summary>
        public bool? ShowCapacities {
            get { return (bool?) Parameters[nameof(ShowCapacities).ToLower()]; }
            set { Parameters[nameof(ShowCapacities).ToLower()] = value; }
        }

        /// <summary>
        /// List zones by resource tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists zones
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ZoneResponse> ListZones(ListZonesRequest request);
        Task<ListResponse<ZoneResponse>> ListZonesAsync(ListZonesRequest request);
        ListResponse<ZoneResponse> ListZonesAllPages(ListZonesRequest request);
        Task<ListResponse<ZoneResponse>> ListZonesAllPagesAsync(ListZonesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ZoneResponse> ListZones(ListZonesRequest request) => _proxy.Request<ListResponse<ZoneResponse>>(request);
        public Task<ListResponse<ZoneResponse>> ListZonesAsync(ListZonesRequest request) => _proxy.RequestAsync<ListResponse<ZoneResponse>>(request);
        public ListResponse<ZoneResponse> ListZonesAllPages(ListZonesRequest request) => _proxy.RequestAllPages<ZoneResponse>(request);
        public Task<ListResponse<ZoneResponse>> ListZonesAllPagesAsync(ListZonesRequest request) => _proxy.RequestAllPagesAsync<ZoneResponse>(request);
    }
}
