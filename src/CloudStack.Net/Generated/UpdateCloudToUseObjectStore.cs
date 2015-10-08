using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateCloudToUseObjectStoreRequest : APIRequest
    {
        public UpdateCloudToUseObjectStoreRequest() : base("updateCloudToUseObjectStore") {}

        /// <summary>
        /// the image store provider name
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// the details for the image store. Example: details[0].key=accesskey&details[0].value=s389ddssaa&details[1].key=secretkey&details[1].value=8dshfsss
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the name for the image store
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the URL for the image store
        /// </summary>
        public string Url { get; set; }

    }
    /// <summary>
    /// Migrate current NFS secondary storages to use object store.
    /// </summary>
    /// <summary>
    /// Migrate current NFS secondary storages to use object store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse UpdateCloudToUseObjectStore(UpdateCloudToUseObjectStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse UpdateCloudToUseObjectStore(UpdateCloudToUseObjectStoreRequest request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
