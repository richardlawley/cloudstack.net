using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSecondaryStagingStoresRequest : APIListRequest
    {
        public ListSecondaryStagingStoresRequest() : base("listSecondaryStagingStores") {}

        /// <summary>
        /// the ID of the staging store
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
        /// the name of the staging store
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the staging store protocol
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the staging store provider
        /// </summary>
        public string Provider {
            get { return (string) Parameters[nameof(Provider).ToLower()]; }
            set { Parameters[nameof(Provider).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the staging store
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists secondary staging stores.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListSecondaryStagingStores(ListSecondaryStagingStoresRequest request);
        Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAsync(ListSecondaryStagingStoresRequest request);
        ListResponse<ImageStoreResponse> ListSecondaryStagingStoresAllPages(ListSecondaryStagingStoresRequest request);
        Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAllPagesAsync(ListSecondaryStagingStoresRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListSecondaryStagingStores(ListSecondaryStagingStoresRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAsync(ListSecondaryStagingStoresRequest request) => _proxy.RequestAsync<ListResponse<ImageStoreResponse>>(request);
        public ListResponse<ImageStoreResponse> ListSecondaryStagingStoresAllPages(ListSecondaryStagingStoresRequest request) => _proxy.RequestAllPages<ImageStoreResponse>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAllPagesAsync(ListSecondaryStagingStoresRequest request) => _proxy.RequestAllPagesAsync<ImageStoreResponse>(request);
    }
}
