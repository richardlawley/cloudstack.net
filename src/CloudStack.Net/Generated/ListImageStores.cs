using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListImageStoresRequest : APIListRequest
    {
        public ListImageStoresRequest() : base("listImageStores") {}

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the image store
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the image store protocol
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the image store provider
        /// </summary>
        public string Provider {
            get { return (string) Parameters[nameof(Provider).ToLower()]; }
            set { Parameters[nameof(Provider).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the image store
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists image stores.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListImageStores(ListImageStoresRequest request);
        Task<ListResponse<ImageStoreResponse>> ListImageStoresAsync(ListImageStoresRequest request);
        ListResponse<ImageStoreResponse> ListImageStoresAllPages(ListImageStoresRequest request);
        Task<ListResponse<ImageStoreResponse>> ListImageStoresAllPagesAsync(ListImageStoresRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListImageStores(ListImageStoresRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
        public Task<ListResponse<ImageStoreResponse>> ListImageStoresAsync(ListImageStoresRequest request) => _proxy.RequestAsync<ListResponse<ImageStoreResponse>>(request);
        public ListResponse<ImageStoreResponse> ListImageStoresAllPages(ListImageStoresRequest request) => _proxy.RequestAllPages<ImageStoreResponse>(request);
        public Task<ListResponse<ImageStoreResponse>> ListImageStoresAllPagesAsync(ListImageStoresRequest request) => _proxy.RequestAllPagesAsync<ImageStoreResponse>(request);
    }
}
