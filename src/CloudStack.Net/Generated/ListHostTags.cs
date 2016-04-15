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
        public ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request) => _proxy.Request<ListResponse<HostTagResponse>>(request);
        public Task<ListResponse<HostTagResponse>> ListHostTagsAsync(ListHostTagsRequest request) => _proxy.RequestAsync<ListResponse<HostTagResponse>>(request);
        public ListResponse<HostTagResponse> ListHostTagsAllPages(ListHostTagsRequest request) => _proxy.RequestAllPages<HostTagResponse>(request);
        public Task<ListResponse<HostTagResponse>> ListHostTagsAllPagesAsync(ListHostTagsRequest request) => _proxy.RequestAllPagesAsync<HostTagResponse>(request);
    }
}
