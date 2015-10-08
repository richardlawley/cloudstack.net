using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSrxFirewallNetworksRequest : APIRequest
    {
        public ListSrxFirewallNetworksRequest() : base("listSrxFirewallNetworks") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid FwDeviceId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// lists network that are using SRX firewall device
    /// </summary>
    /// <summary>
    /// lists network that are using SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListSrxFirewallNetworks(ListSrxFirewallNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListSrxFirewallNetworks(ListSrxFirewallNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
