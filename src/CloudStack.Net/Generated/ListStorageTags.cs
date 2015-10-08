using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageTagsRequest : APIRequest
    {
        public ListStorageTagsRequest() : base("listStorageTags") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists storage tags
    /// </summary>
    /// <summary>
    /// Lists storage tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageTagResponse> ListStorageTags(ListStorageTagsRequest request) => _proxy.Request<ListResponse<StorageTagResponse>>(request);
    }
}
