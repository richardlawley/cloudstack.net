using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficTypesRequest : APIRequest
    {
        public ListTrafficTypesRequest() : base("listTrafficTypes") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists traffic types of a given physical network.
    /// </summary>
    /// <summary>
    /// Lists traffic types of a given physical network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProviderResponse> ListTrafficTypes(ListTrafficTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProviderResponse> ListTrafficTypes(ListTrafficTypesRequest request) => _proxy.Request<ListResponse<ProviderResponse>>(request);
    }
}
