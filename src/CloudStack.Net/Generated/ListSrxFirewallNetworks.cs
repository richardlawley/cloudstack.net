using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSrxFirewallNetworksRequest : APIListRequest
    {
        public ListSrxFirewallNetworksRequest() : base("listSrxFirewallNetworks") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid Lbdeviceid {
            get { return GetParameterValue<Guid>(nameof(Lbdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Lbdeviceid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// lists network that are using SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListSrxFirewallNetworks(ListSrxFirewallNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListSrxFirewallNetworksAsync(ListSrxFirewallNetworksRequest request);
        ListResponse<NetworkResponse> ListSrxFirewallNetworksAllPages(ListSrxFirewallNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListSrxFirewallNetworksAllPagesAsync(ListSrxFirewallNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListSrxFirewallNetworks(ListSrxFirewallNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListSrxFirewallNetworksAsync(ListSrxFirewallNetworksRequest request) => _proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListSrxFirewallNetworksAllPages(ListSrxFirewallNetworksRequest request) => _proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListSrxFirewallNetworksAllPagesAsync(ListSrxFirewallNetworksRequest request) => _proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
