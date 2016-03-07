using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSrxFirewallsRequest : APIListRequest
    {
        public ListSrxFirewallsRequest() : base("listSrxFirewalls") {}

        /// <summary>
        /// SRX firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return (Guid) Parameters[nameof(FwDeviceId).ToLower()]; }
            set { Parameters[nameof(FwDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// lists SRX firewall devices in a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SrxFirewallResponse> ListSrxFirewalls(ListSrxFirewallsRequest request);
        Task<ListResponse<SrxFirewallResponse>> ListSrxFirewallsAsync(ListSrxFirewallsRequest request);
        ListResponse<SrxFirewallResponse> ListSrxFirewallsAllPages(ListSrxFirewallsRequest request);
        Task<ListResponse<SrxFirewallResponse>> ListSrxFirewallsAllPagesAsync(ListSrxFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SrxFirewallResponse> ListSrxFirewalls(ListSrxFirewallsRequest request) => _proxy.Request<ListResponse<SrxFirewallResponse>>(request);
        public Task<ListResponse<SrxFirewallResponse>> ListSrxFirewallsAsync(ListSrxFirewallsRequest request) => _proxy.RequestAsync<ListResponse<SrxFirewallResponse>>(request);
        public ListResponse<SrxFirewallResponse> ListSrxFirewallsAllPages(ListSrxFirewallsRequest request) => _proxy.RequestAllPages<SrxFirewallResponse>(request);
        public Task<ListResponse<SrxFirewallResponse>> ListSrxFirewallsAllPagesAsync(ListSrxFirewallsRequest request) => _proxy.RequestAllPagesAsync<SrxFirewallResponse>(request);
    }
}
