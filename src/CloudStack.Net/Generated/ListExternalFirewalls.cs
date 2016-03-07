using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListExternalFirewallsRequest : APIListRequest
    {
        public ListExternalFirewallsRequest() : base("listExternalFirewalls") {}

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List external firewall appliances.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ExternalFirewallResponse> ListExternalFirewalls(ListExternalFirewallsRequest request);
        Task<ListResponse<ExternalFirewallResponse>> ListExternalFirewallsAsync(ListExternalFirewallsRequest request);
        ListResponse<ExternalFirewallResponse> ListExternalFirewallsAllPages(ListExternalFirewallsRequest request);
        Task<ListResponse<ExternalFirewallResponse>> ListExternalFirewallsAllPagesAsync(ListExternalFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ExternalFirewallResponse> ListExternalFirewalls(ListExternalFirewallsRequest request) => _proxy.Request<ListResponse<ExternalFirewallResponse>>(request);
        public Task<ListResponse<ExternalFirewallResponse>> ListExternalFirewallsAsync(ListExternalFirewallsRequest request) => _proxy.RequestAsync<ListResponse<ExternalFirewallResponse>>(request);
        public ListResponse<ExternalFirewallResponse> ListExternalFirewallsAllPages(ListExternalFirewallsRequest request) => _proxy.RequestAllPages<ExternalFirewallResponse>(request);
        public Task<ListResponse<ExternalFirewallResponse>> ListExternalFirewallsAllPagesAsync(ListExternalFirewallsRequest request) => _proxy.RequestAllPagesAsync<ExternalFirewallResponse>(request);
    }
}
