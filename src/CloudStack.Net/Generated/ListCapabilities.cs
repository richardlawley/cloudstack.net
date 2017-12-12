using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCapabilitiesRequest : APIRequest
    {
        public ListCapabilitiesRequest() : base("listCapabilities") {}

    }
    /// <summary>
    /// Lists capabilities
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request);
        Task<CapabilitiesResponse> ListCapabilitiesAsync(ListCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request) => Proxy.Request<CapabilitiesResponse>(request);
        public Task<CapabilitiesResponse> ListCapabilitiesAsync(ListCapabilitiesRequest request) => Proxy.RequestAsync<CapabilitiesResponse>(request);
    }
}
