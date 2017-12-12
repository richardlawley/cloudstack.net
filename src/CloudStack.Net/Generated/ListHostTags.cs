using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostTagsRequest : APIListRequest
    {
        public ListHostTagsRequest() : base("listHostTags") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists host tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request);
        Task<ListResponse<HostTagResponse>> ListHostTagsAsync(ListHostTagsRequest request);
        ListResponse<HostTagResponse> ListHostTagsAllPages(ListHostTagsRequest request);
        Task<ListResponse<HostTagResponse>> ListHostTagsAllPagesAsync(ListHostTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request) => Proxy.Request<ListResponse<HostTagResponse>>(request);
        public Task<ListResponse<HostTagResponse>> ListHostTagsAsync(ListHostTagsRequest request) => Proxy.RequestAsync<ListResponse<HostTagResponse>>(request);
        public ListResponse<HostTagResponse> ListHostTagsAllPages(ListHostTagsRequest request) => Proxy.RequestAllPages<HostTagResponse>(request);
        public Task<ListResponse<HostTagResponse>> ListHostTagsAllPagesAsync(ListHostTagsRequest request) => Proxy.RequestAllPagesAsync<HostTagResponse>(request);
    }
}
