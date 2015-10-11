using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IdpResponse ListIdps(ListIdpsRequest request) => _proxy.Request<IdpResponse>(request);
    }
}
