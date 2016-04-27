using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedGuestVlanRangesRequest : APIListRequest
    {
        public ListDedicatedGuestVlanRangesRequest() : base("listDedicatedGuestVlanRanges") {}

        /// <summary>
        /// the account with which the guest VLAN range is associated. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID with which the guest VLAN range is associated.  If used with the account parameter, returns all guest VLAN ranges for that account in the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the dedicated guest vlan range
        /// </summary>
        public string GuestVlanRange {
            get { return GetParameterValue<string>(nameof(GuestVlanRange).ToLower()); }
            set { SetParameterValue(nameof(GuestVlanRange).ToLower(), value); }
        }

        /// <summary>
        /// list dedicated guest vlan ranges by id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// physical network id of the guest VLAN range
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// project who will own the guest VLAN range
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// zone of the guest VLAN range
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists dedicated guest vlan ranges
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request);
        Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAsync(ListDedicatedGuestVlanRangesRequest request);
        ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRangesAllPages(ListDedicatedGuestVlanRangesRequest request);
        Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAllPagesAsync(ListDedicatedGuestVlanRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request) => _proxy.Request<ListResponse<GuestVlanRangeResponse>>(request);
        public Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAsync(ListDedicatedGuestVlanRangesRequest request) => _proxy.RequestAsync<ListResponse<GuestVlanRangeResponse>>(request);
        public ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRangesAllPages(ListDedicatedGuestVlanRangesRequest request) => _proxy.RequestAllPages<GuestVlanRangeResponse>(request);
        public Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAllPagesAsync(ListDedicatedGuestVlanRangesRequest request) => _proxy.RequestAllPagesAsync<GuestVlanRangeResponse>(request);
    }
}
