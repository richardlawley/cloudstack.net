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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list dedicated zones by affinity group
        /// </summary>
        public Guid? AffinityGroupId {
            get { return GetParameterValue<Guid?>(nameof(AffinityGroupId).ToLower()); }
            set { SetParameterValue(nameof(AffinityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        public ListResponse<DedicateZoneResponse> ListDedicatedZones(ListDedicatedZonesRequest request) => Proxy.Request<ListResponse<DedicateZoneResponse>>(request);
        public Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAsync(ListDedicatedZonesRequest request) => Proxy.RequestAsync<ListResponse<DedicateZoneResponse>>(request);
        public ListResponse<DedicateZoneResponse> ListDedicatedZonesAllPages(ListDedicatedZonesRequest request) => Proxy.RequestAllPages<DedicateZoneResponse>(request);
        public Task<ListResponse<DedicateZoneResponse>> ListDedicatedZonesAllPagesAsync(ListDedicatedZonesRequest request) => Proxy.RequestAllPagesAsync<DedicateZoneResponse>(request);
    }
}
