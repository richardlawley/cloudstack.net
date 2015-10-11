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
        public Guid Lbdeviceid {
            get { return (Guid) Parameters[nameof(Lbdeviceid).ToLower()]; }
            set { Parameters[nameof(Lbdeviceid).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
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
