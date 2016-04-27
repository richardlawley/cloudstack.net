using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSecondaryStagingStoreRequest : APIRequest
    {
        public CreateSecondaryStagingStoreRequest() : base("createSecondaryStagingStore") {}

        /// <summary>
        /// the URL for the staging store
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the details for the staging store
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the staging store provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the scope of the staging store: zone only for now
        /// </summary>
        public string Scope {
            get { return GetParameterValue<string>(nameof(Scope).ToLower()); }
            set { SetParameterValue(nameof(Scope).ToLower(), value); }
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
    /// create secondary staging store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse CreateSecondaryStagingStore(CreateSecondaryStagingStoreRequest request);
        Task<ImageStoreResponse> CreateSecondaryStagingStoreAsync(CreateSecondaryStagingStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse CreateSecondaryStagingStore(CreateSecondaryStagingStoreRequest request) => _proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> CreateSecondaryStagingStoreAsync(CreateSecondaryStagingStoreRequest request) => _proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
