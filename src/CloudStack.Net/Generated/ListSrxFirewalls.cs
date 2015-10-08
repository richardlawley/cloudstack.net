using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSrxFirewallsRequest : APIRequest
    {
        public ListSrxFirewallsRequest() : base("listSrxFirewalls") {}

        /// <summary>
        /// SRX firewall device ID
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
    /// lists SRX firewall devices in a physical network
    /// </summary>
    /// <summary>
    /// lists SRX firewall devices in a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SrxFirewallResponse> ListSrxFirewalls(ListSrxFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SrxFirewallResponse> ListSrxFirewalls(ListSrxFirewallsRequest request) => _proxy.Request<ListResponse<SrxFirewallResponse>>(request);
    }
}
