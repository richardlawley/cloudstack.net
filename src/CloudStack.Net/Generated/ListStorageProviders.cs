using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageProvidersRequest : APIRequest
    {
        public ListStorageProvidersRequest() : base("listStorageProviders") {}

        /// <summary>
        /// the type of storage provider: either primary or image
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists storage providers.
    /// </summary>
    /// <summary>
    /// Lists storage providers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request) => _proxy.Request<ListResponse<StorageProviderResponse>>(request);
    }
}
