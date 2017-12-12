using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVlanIpRangesRequest : APIListRequest
    {
        public ListVlanIpRangesRequest() : base("listVlanIpRanges") {}

        /// <summary>
        /// the account with which the VLAN IP range is associated. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID with which the VLAN IP range is associated.  If used with the account parameter, returns all VLAN IP ranges for that account in the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// true if VLAN is of Virtual type, false if Direct
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return GetParameterValue<bool?>(nameof(ForVirtualNetwork).ToLower()); }
            set { SetParameterValue(nameof(ForVirtualNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the VLAN IP range
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
        /// network id of the VLAN IP range
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// physical network id of the VLAN IP range
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID of the VLAN IP range
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the ID or VID of the VLAN. Default is an "untagged" VLAN.
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all VLAN IP ranges.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VlanIpRangeResponse> ListVlanIpRanges(ListVlanIpRangesRequest request);
        Task<ListResponse<VlanIpRangeResponse>> ListVlanIpRangesAsync(ListVlanIpRangesRequest request);
        ListResponse<VlanIpRangeResponse> ListVlanIpRangesAllPages(ListVlanIpRangesRequest request);
        Task<ListResponse<VlanIpRangeResponse>> ListVlanIpRangesAllPagesAsync(ListVlanIpRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VlanIpRangeResponse> ListVlanIpRanges(ListVlanIpRangesRequest request) => Proxy.Request<ListResponse<VlanIpRangeResponse>>(request);
        public Task<ListResponse<VlanIpRangeResponse>> ListVlanIpRangesAsync(ListVlanIpRangesRequest request) => Proxy.RequestAsync<ListResponse<VlanIpRangeResponse>>(request);
        public ListResponse<VlanIpRangeResponse> ListVlanIpRangesAllPages(ListVlanIpRangesRequest request) => Proxy.RequestAllPages<VlanIpRangeResponse>(request);
        public Task<ListResponse<VlanIpRangeResponse>> ListVlanIpRangesAllPagesAsync(ListVlanIpRangesRequest request) => Proxy.RequestAllPagesAsync<VlanIpRangeResponse>(request);
    }
}
