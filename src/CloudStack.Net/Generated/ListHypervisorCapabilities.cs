using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHypervisorCapabilitiesRequest : APIListRequest
    {
        public ListHypervisorCapabilitiesRequest() : base("listHypervisorCapabilities") {}

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// ID of the hypervisor capability
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
    /// Lists all hypervisor capabilities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request);
        Task<ListResponse<HypervisorCapabilitiesResponse>> ListHypervisorCapabilitiesAsync(ListHypervisorCapabilitiesRequest request);
        ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilitiesAllPages(ListHypervisorCapabilitiesRequest request);
        Task<ListResponse<HypervisorCapabilitiesResponse>> ListHypervisorCapabilitiesAllPagesAsync(ListHypervisorCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request) => _proxy.Request<ListResponse<HypervisorCapabilitiesResponse>>(request);
        public Task<ListResponse<HypervisorCapabilitiesResponse>> ListHypervisorCapabilitiesAsync(ListHypervisorCapabilitiesRequest request) => _proxy.RequestAsync<ListResponse<HypervisorCapabilitiesResponse>>(request);
        public ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilitiesAllPages(ListHypervisorCapabilitiesRequest request) => _proxy.RequestAllPages<HypervisorCapabilitiesResponse>(request);
        public Task<ListResponse<HypervisorCapabilitiesResponse>> ListHypervisorCapabilitiesAllPagesAsync(ListHypervisorCapabilitiesRequest request) => _proxy.RequestAllPagesAsync<HypervisorCapabilitiesResponse>(request);
    }
}
