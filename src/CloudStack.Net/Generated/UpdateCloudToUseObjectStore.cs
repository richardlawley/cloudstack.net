using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateCloudToUseObjectStoreRequest : APIRequest
    {
        public UpdateCloudToUseObjectStoreRequest() : base("updateCloudToUseObjectStore") {}

        /// <summary>
        /// the image store provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the details for the image store. Example: details[0].key=accesskey&details[0].value=s389ddssaa&details[1].key=secretkey&details[1].value=8dshfsss
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the name for the image store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL for the image store
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

    }
    /// <summary>
    /// Migrate current NFS secondary storages to use object store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse UpdateCloudToUseObjectStore(UpdateCloudToUseObjectStoreRequest request);
        Task<ImageStoreResponse> UpdateCloudToUseObjectStoreAsync(UpdateCloudToUseObjectStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse UpdateCloudToUseObjectStore(UpdateCloudToUseObjectStoreRequest request) => Proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> UpdateCloudToUseObjectStoreAsync(UpdateCloudToUseObjectStoreRequest request) => Proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
