using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedZonesRequest : APIListRequest
    {
        public ListDedicatedZonesRequest() : base("listDedicatedZones") {}

        /// <summary>
        /// the name of the account associated with the zone. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list dedicated zones by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return (Guid) Parameters[nameof(AffinityGroupId).ToLower()]; }
            set { Parameters[nameof(AffinityGroupId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List dedicated zones.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateZoneResponse> ListDedicatedZones(ListDedicatedZonesRequest request);
        Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAsync(ListDedicatedZonesRequest request);
        ListResponse<DedicateZoneResponse> ListDedicatedZonesAllPages(ListDedicatedZonesRequest request);
        Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAllPagesAsync(ListDedicatedZonesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateZoneResponse> ListDedicatedZones(ListDedicatedZonesRequest request) => _proxy.Request<ListResponse<DedicateZoneResponse>>(request);
        public Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAsync(ListDedicatedZonesRequest request) => _proxy.RequestAsync<ListResponse<DedicateZoneResponse>>(request);
        public ListResponse<DedicateZoneResponse> ListDedicatedZonesAllPages(ListDedicatedZonesRequest request) => _proxy.RequestAllPages<DedicateZoneResponse>(request);
        public Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAllPagesAsync(ListDedicatedZonesRequest request) => _proxy.RequestAllPagesAsync<DedicateZoneResponse>(request);
    }
}
