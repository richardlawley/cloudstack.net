using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListImageStoresRequest : APIRequest
    {
        public ListImageStoresRequest() : base("listImageStores") {}

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the image store
        /// </summary>
        public string StoreName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the image store protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the image store provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the Zone ID for the image store
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists image stores.
    /// </summary>
    /// <summary>
    /// Lists image stores.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListImageStores(ListImageStoresRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListImageStores(ListImageStoresRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
    }
}
