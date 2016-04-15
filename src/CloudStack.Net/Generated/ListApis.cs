using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListApisRequest : APIRequest
    {
        public ListApisRequest() : base("listApis") {}

        /// <summary>
        /// API name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// lists all available apis on the server, provided by the Api Discovery plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiDiscoveryResponse ListApis(ListApisRequest request);
        Task<ApiDiscoveryResponse> ListApisAsync(ListApisRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiDiscoveryResponse ListApis(ListApisRequest request) => _proxy.Request<ApiDiscoveryResponse>(request);
        public Task<ApiDiscoveryResponse> ListApisAsync(ListApisRequest request) => _proxy.RequestAsync<ApiDiscoveryResponse>(request);
    }
}
