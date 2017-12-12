using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPaloAltoFirewallNetworksRequest : APIListRequest
    {
        public ListPaloAltoFirewallNetworksRequest() : base("listPaloAltoFirewallNetworks") {}

        /// <summary>
        /// palo alto balancer device ID
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
    /// lists network that are using Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListPaloAltoFirewallNetworks(ListPaloAltoFirewallNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListPaloAltoFirewallNetworksAsync(ListPaloAltoFirewallNetworksRequest request);
        ListResponse<NetworkResponse> ListPaloAltoFirewallNetworksAllPages(ListPaloAltoFirewallNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListPaloAltoFirewallNetworksAllPagesAsync(ListPaloAltoFirewallNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListPaloAltoFirewallNetworks(ListPaloAltoFirewallNetworksRequest request) => Proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListPaloAltoFirewallNetworksAsync(ListPaloAltoFirewallNetworksRequest request) => Proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListPaloAltoFirewallNetworksAllPages(ListPaloAltoFirewallNetworksRequest request) => Proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListPaloAltoFirewallNetworksAllPagesAsync(ListPaloAltoFirewallNetworksRequest request) => Proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
