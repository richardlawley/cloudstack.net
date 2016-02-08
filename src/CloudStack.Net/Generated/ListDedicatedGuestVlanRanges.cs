using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedGuestVlanRangesRequest : APIRequest
    {
        public ListDedicatedGuestVlanRangesRequest() : base("listDedicatedGuestVlanRanges") {}

        /// <summary>
        /// the account with which the guest VLAN range is associated. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID with which the guest VLAN range is associated.  If used with the account parameter, returns all guest VLAN ranges for that account in the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the dedicated guest vlan range
        /// </summary>
        public string GuestVlanRange {
            get { return (string) Parameters[nameof(GuestVlanRange).ToLower()]; }
            set { Parameters[nameof(GuestVlanRange).ToLower()] = value; }
        }

        /// <summary>
        /// list dedicated guest vlan ranges by id
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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// physical network id of the guest VLAN range
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// project who will own the guest VLAN range
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// zone of the guest VLAN range
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists dedicated guest vlan ranges
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request);
        Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAsync(ListDedicatedGuestVlanRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request) => _proxy.Request<ListResponse<GuestVlanRangeResponse>>(request);
        public Task<ListResponse<GuestVlanRangeResponse>> ListDedicatedGuestVlanRangesAsync(ListDedicatedGuestVlanRangesRequest request) => _proxy.RequestAsync<ListResponse<GuestVlanRangeResponse>>(request);
    }
}
