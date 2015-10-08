using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPaloAltoFirewallNetworksRequest : APIRequest
    {
        public ListPaloAltoFirewallNetworksRequest() : base("listPaloAltoFirewallNetworks") {}

        /// <summary>
        /// palo alto balancer device ID
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
    /// lists network that are using Palo Alto firewall device
    /// </summary>
    /// <summary>
    /// lists network that are using Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListPaloAltoFirewallNetworks(ListPaloAltoFirewallNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListPaloAltoFirewallNetworks(ListPaloAltoFirewallNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
