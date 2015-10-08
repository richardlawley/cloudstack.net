using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListExternalFirewallsRequest : APIRequest
    {
        public ListExternalFirewallsRequest() : base("listExternalFirewalls") {}

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List external firewall appliances.
    /// </summary>
    /// <summary>
    /// List external firewall appliances.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ExternalFirewallResponse> ListExternalFirewalls(ListExternalFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ExternalFirewallResponse> ListExternalFirewalls(ListExternalFirewallsRequest request) => _proxy.Request<ListResponse<ExternalFirewallResponse>>(request);
    }
}
