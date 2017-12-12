using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkIsolationMethodsRequest : APIListRequest
    {
        public ListNetworkIsolationMethodsRequest() : base("listNetworkIsolationMethods") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists supported methods of network isolation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<IsolationMethodResponse> ListNetworkIsolationMethods(ListNetworkIsolationMethodsRequest request);
        Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAsync(ListNetworkIsolationMethodsRequest request);
        ListResponse<IsolationMethodResponse> ListNetworkIsolationMethodsAllPages(ListNetworkIsolationMethodsRequest request);
        Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAllPagesAsync(ListNetworkIsolationMethodsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<IsolationMethodResponse> ListNetworkIsolationMethods(ListNetworkIsolationMethodsRequest request) => Proxy.Request<ListResponse<IsolationMethodResponse>>(request);
        public Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAsync(ListNetworkIsolationMethodsRequest request) => Proxy.RequestAsync<ListResponse<IsolationMethodResponse>>(request);
        public ListResponse<IsolationMethodResponse> ListNetworkIsolationMethodsAllPages(ListNetworkIsolationMethodsRequest request) => Proxy.RequestAllPages<IsolationMethodResponse>(request);
        public Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAllPagesAsync(ListNetworkIsolationMethodsRequest request) => Proxy.RequestAllPagesAsync<IsolationMethodResponse>(request);
    }
}
