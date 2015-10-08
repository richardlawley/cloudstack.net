using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkIsolationMethodsRequest : APIRequest
    {
        public ListNetworkIsolationMethodsRequest() : base("listNetworkIsolationMethods") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists supported methods of network isolation
    /// </summary>
    /// <summary>
    /// Lists supported methods of network isolation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<IsolationMethodResponse> ListNetworkIsolationMethods(ListNetworkIsolationMethodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<IsolationMethodResponse> ListNetworkIsolationMethods(ListNetworkIsolationMethodsRequest request) => _proxy.Request<ListResponse<IsolationMethodResponse>>(request);
    }
}
