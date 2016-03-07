using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoAsa1000vResourcesRequest : APIListRequest
    {
        public ListCiscoAsa1000vResourcesRequest() : base("listCiscoAsa1000vResources") {}

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
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

        /// <summary>
        /// Cisco ASA 1000v resource ID
        /// </summary>
        public Guid Resourceid {
            get { return (Guid) Parameters[nameof(Resourceid).ToLower()]; }
            set { Parameters[nameof(Resourceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Cisco ASA 1000v appliances
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request);
        Task<ListResponse<CiscoAsa1000vResourceResponse>> ListCiscoAsa1000vResourcesAsync(ListCiscoAsa1000vResourcesRequest request);
        ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResourcesAllPages(ListCiscoAsa1000vResourcesRequest request);
        Task<ListResponse<CiscoAsa1000vResourceResponse>> ListCiscoAsa1000vResourcesAllPagesAsync(ListCiscoAsa1000vResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request) => _proxy.Request<ListResponse<CiscoAsa1000vResourceResponse>>(request);
        public Task<ListResponse<CiscoAsa1000vResourceResponse>> ListCiscoAsa1000vResourcesAsync(ListCiscoAsa1000vResourcesRequest request) => _proxy.RequestAsync<ListResponse<CiscoAsa1000vResourceResponse>>(request);
        public ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResourcesAllPages(ListCiscoAsa1000vResourcesRequest request) => _proxy.RequestAllPages<CiscoAsa1000vResourceResponse>(request);
        public Task<ListResponse<CiscoAsa1000vResourceResponse>> ListCiscoAsa1000vResourcesAllPagesAsync(ListCiscoAsa1000vResourcesRequest request) => _proxy.RequestAllPagesAsync<CiscoAsa1000vResourceResponse>(request);
    }
}
