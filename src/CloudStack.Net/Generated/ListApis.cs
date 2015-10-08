using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListApisRequest : APIRequest
    {
        public ListApisRequest() : base("listApis") {}

        /// <summary>
        /// API name
        /// </summary>
        public string Name { get; set; }

    }
    /// <summary>
    /// lists all available apis on the server, provided by the Api Discovery plugin
    /// </summary>
    /// <summary>
    /// lists all available apis on the server, provided by the Api Discovery plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiDiscoveryResponse ListApis(ListApisRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiDiscoveryResponse ListApis(ListApisRequest request) => _proxy.Request<ApiDiscoveryResponse>(request);
    }
}
