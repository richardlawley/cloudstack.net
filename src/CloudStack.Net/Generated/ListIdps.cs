using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIdpsRequest : APIRequest
    {
        public ListIdpsRequest() : base("listIdps") {}

    }
    /// <summary>
    /// Returns list of discovered SAML Identity Providers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IdpResponse ListIdps(ListIdpsRequest request);
        Task<IdpResponse> ListIdpsAsync(ListIdpsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IdpResponse ListIdps(ListIdpsRequest request) => Proxy.Request<IdpResponse>(request);
        public Task<IdpResponse> ListIdpsAsync(ListIdpsRequest request) => Proxy.RequestAsync<IdpResponse>(request);
    }
}
