using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPaloAltoFirewallsRequest : APIListRequest
    {
        public ListPaloAltoFirewallsRequest() : base("listPaloAltoFirewalls") {}

        /// <summary>
        /// Palo Alto firewall device ID
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
    /// lists Palo Alto firewall devices in a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request);
        Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAsync(ListPaloAltoFirewallsRequest request);
        ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewallsAllPages(ListPaloAltoFirewallsRequest request);
        Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAllPagesAsync(ListPaloAltoFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request) => _proxy.Request<ListResponse<PaloAltoFirewallResponse>>(request);
        public Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAsync(ListPaloAltoFirewallsRequest request) => _proxy.RequestAsync<ListResponse<PaloAltoFirewallResponse>>(request);
        public ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewallsAllPages(ListPaloAltoFirewallsRequest request) => _proxy.RequestAllPages<PaloAltoFirewallResponse>(request);
        public Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAllPagesAsync(ListPaloAltoFirewallsRequest request) => _proxy.RequestAllPagesAsync<PaloAltoFirewallResponse>(request);
    }
}
