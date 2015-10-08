using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSecondaryStagingStoresRequest : APIRequest
    {
        public ListSecondaryStagingStoresRequest() : base("listSecondaryStagingStores") {}

        /// <summary>
        /// the ID of the staging store
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the staging store
        /// </summary>
        public string StoreName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the staging store protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the staging store provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the Zone ID for the staging store
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists secondary staging stores.
    /// </summary>
    /// <summary>
    /// Lists secondary staging stores.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListSecondaryStagingStores(ListSecondaryStagingStoresRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListSecondaryStagingStores(ListSecondaryStagingStoresRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
    }
}
