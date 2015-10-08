using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPaloAltoFirewallsRequest : APIRequest
    {
        public ListPaloAltoFirewallsRequest() : base("listPaloAltoFirewalls") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

    }
    /// <summary>
    /// lists Palo Alto firewall devices in a physical network
    /// </summary>
    /// <summary>
    /// lists Palo Alto firewall devices in a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request) => _proxy.Request<ListResponse<PaloAltoFirewallResponse>>(request);
    }
}
