using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVlanIpRangesRequest : APIRequest
    {
        public ListVlanIpRangesRequest() : base("listVlanIpRanges") {}

        /// <summary>
        /// the account with which the VLAN IP range is associated. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID with which the VLAN IP range is associated.  If used with the account parameter, returns all VLAN IP ranges for that account in the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// true if VLAN is of Virtual type, false if Direct
        /// </summary>
        public bool? ForVirtualNetwork { get; set; }

        /// <summary>
        /// the ID of the VLAN IP range
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// network id of the VLAN IP range
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// physical network id of the VLAN IP range
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the Pod ID of the VLAN IP range
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the ID or VID of the VLAN. Default is an "untagged" VLAN.
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all VLAN IP ranges.
    /// </summary>
    /// <summary>
    /// Lists all VLAN IP ranges.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VlanIpRangeResponse> ListVlanIpRanges(ListVlanIpRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VlanIpRangeResponse> ListVlanIpRanges(ListVlanIpRangesRequest request) => _proxy.Request<ListResponse<VlanIpRangeResponse>>(request);
    }
}
