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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the name of the image store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the image store protocol
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the image store provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the image store
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
