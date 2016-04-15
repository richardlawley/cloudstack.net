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
        public ListResponse<IsolationMethodResponse> ListNetworkIsolationMethods(ListNetworkIsolationMethodsRequest request) => _proxy.Request<ListResponse<IsolationMethodResponse>>(request);
        public Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAsync(ListNetworkIsolationMethodsRequest request) => _proxy.RequestAsync<ListResponse<IsolationMethodResponse>>(request);
        public ListResponse<IsolationMethodResponse> ListNetworkIsolationMethodsAllPages(ListNetworkIsolationMethodsRequest request) => _proxy.RequestAllPages<IsolationMethodResponse>(request);
        public Task<ListResponse<IsolationMethodResponse>> ListNetworkIsolationMethodsAllPagesAsync(ListNetworkIsolationMethodsRequest request) => _proxy.RequestAllPagesAsync<IsolationMethodResponse>(request);
    }
}
