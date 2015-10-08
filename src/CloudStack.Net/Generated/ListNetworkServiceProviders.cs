using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkServiceProvidersRequest : APIRequest
    {
        public ListNetworkServiceProvidersRequest() : base("listNetworkServiceProviders") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list providers by name
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// list providers by state
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Lists network serviceproviders for a given physical network.
    /// </summary>
    /// <summary>
    /// Lists network serviceproviders for a given physical network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request) => _proxy.Request<ListResponse<ProviderResponse>>(request);
    }
}
