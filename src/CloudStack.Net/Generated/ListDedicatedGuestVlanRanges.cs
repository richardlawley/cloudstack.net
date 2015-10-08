using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedGuestVlanRangesRequest : APIRequest
    {
        public ListDedicatedGuestVlanRangesRequest() : base("listDedicatedGuestVlanRanges") {}

        /// <summary>
        /// the account with which the guest VLAN range is associated. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID with which the guest VLAN range is associated.  If used with the account parameter, returns all guest VLAN ranges for that account in the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the dedicated guest vlan range
        /// </summary>
        public string GuestVlanRange { get; set; }

        /// <summary>
        /// list dedicated guest vlan ranges by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// physical network id of the guest VLAN range
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// project who will own the guest VLAN range
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// zone of the guest VLAN range
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists dedicated guest vlan ranges
    /// </summary>
    /// <summary>
    /// Lists dedicated guest vlan ranges
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestVlanRangeResponse> ListDedicatedGuestVlanRanges(ListDedicatedGuestVlanRangesRequest request) => _proxy.Request<ListResponse<GuestVlanRangeResponse>>(request);
    }
}
