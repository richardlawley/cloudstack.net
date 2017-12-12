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
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// the name of the staging store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the staging store protocol
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the staging store provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the staging store
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        public ListResponse<ImageStoreResponse> ListSecondaryStagingStores(ListSecondaryStagingStoresRequest request) => Proxy.Request<ListResponse<ImageStoreResponse>>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAsync(ListSecondaryStagingStoresRequest request) => Proxy.RequestAsync<ListResponse<ImageStoreResponse>>(request);
        public ListResponse<ImageStoreResponse> ListSecondaryStagingStoresAllPages(ListSecondaryStagingStoresRequest request) => Proxy.RequestAllPages<ImageStoreResponse>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSecondaryStagingStoresAllPagesAsync(ListSecondaryStagingStoresRequest request) => Proxy.RequestAllPagesAsync<ImageStoreResponse>(request);
    }
}
