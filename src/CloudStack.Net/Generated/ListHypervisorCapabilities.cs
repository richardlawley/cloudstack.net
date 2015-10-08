using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHypervisorCapabilitiesRequest : APIRequest
    {
        public ListHypervisorCapabilitiesRequest() : base("listHypervisorCapabilities") {}

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// ID of the hypervisor capability
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all hypervisor capabilities.
    /// </summary>
    /// <summary>
    /// Lists all hypervisor capabilities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request) => _proxy.Request<ListResponse<HypervisorCapabilitiesResponse>>(request);
    }
}
