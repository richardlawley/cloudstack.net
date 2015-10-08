using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListEventTypesRequest : APIRequest
    {
        public ListEventTypesRequest() : base("listEventTypes") {}

    }
    /// <summary>
    /// List Event Types
    /// </summary>
    /// <summary>
    /// List Event Types
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        EventTypeResponse ListEventTypes(ListEventTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public EventTypeResponse ListEventTypes(ListEventTypesRequest request) => _proxy.Request<EventTypeResponse>(request);
    }
}
