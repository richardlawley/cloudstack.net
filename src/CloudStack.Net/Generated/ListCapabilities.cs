using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request) => _proxy.Request<CapabilitiesResponse>(request);
    }
}
