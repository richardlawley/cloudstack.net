using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSupportedNetworkServicesRequest : APIRequest
    {
        public ListSupportedNetworkServicesRequest() : base("listSupportedNetworkServices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// network service provider name
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// network service name to list providers and capabilities of
        /// </summary>
        public string ServiceName { get; set; }

    }
    /// <summary>
    /// Lists all network services provided by CloudStack or for the given Provider.
    /// </summary>
    /// <summary>
    /// Lists all network services provided by CloudStack or for the given Provider.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request) => _proxy.Request<ListResponse<ServiceResponse>>(request);
    }
}
