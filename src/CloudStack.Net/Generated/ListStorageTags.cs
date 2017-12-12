using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageTagsRequest : APIListRequest
    {
        public ListStorageTagsRequest() : base("listStorageTags") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists storage tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request);
        Task<ListResponse<StorageTagResponse>> ListStorageTagsAsync(ListStorageTagsRequest request);
        ListResponse<StorageTagResponse> ListStorageTagsAllPages(ListStorageTagsRequest request);
        Task<ListResponse<StorageTagResponse>> ListStorageTagsAllPagesAsync(ListStorageTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request) => Proxy.Request<ListResponse<StorageTagResponse>>(request);
        public Task<ListResponse<StorageTagResponse>> ListStorageTagsAsync(ListStorageTagsRequest request) => Proxy.RequestAsync<ListResponse<StorageTagResponse>>(request);
        public ListResponse<StorageTagResponse> ListStorageTagsAllPages(ListStorageTagsRequest request) => Proxy.RequestAllPages<StorageTagResponse>(request);
        public Task<ListResponse<StorageTagResponse>> ListStorageTagsAllPagesAsync(ListStorageTagsRequest request) => Proxy.RequestAllPagesAsync<StorageTagResponse>(request);
    }
}
