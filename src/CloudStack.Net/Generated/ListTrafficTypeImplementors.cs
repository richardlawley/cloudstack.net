using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficTypeImplementorsRequest : APIRequest
    {
        public ListTrafficTypeImplementorsRequest() : base("listTrafficTypeImplementors") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Optional. The network traffic type, if specified, return its implementor. Otherwise, return all traffic types with their implementor
        /// </summary>
        public string TrafficType { get; set; }

    }
    /// <summary>
    /// Lists implementors of implementor of a network traffic type or implementors of all network traffic types
    /// </summary>
    /// <summary>
    /// Lists implementors of implementor of a network traffic type or implementors of all network traffic types
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementors(ListTrafficTypeImplementorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementors(ListTrafficTypeImplementorsRequest request) => _proxy.Request<ListResponse<TrafficTypeImplementorResponse>>(request);
    }
}
