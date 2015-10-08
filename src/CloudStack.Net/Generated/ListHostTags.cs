using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostTagsRequest : APIRequest
    {
        public ListHostTagsRequest() : base("listHostTags") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists host tags
    /// </summary>
    /// <summary>
    /// Lists host tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request) => _proxy.Request<ListResponse<HostTagResponse>>(request);
    }
}
