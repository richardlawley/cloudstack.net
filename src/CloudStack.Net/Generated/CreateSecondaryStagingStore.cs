using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSecondaryStagingStoreRequest : APIRequest
    {
        public CreateSecondaryStagingStoreRequest() : base("createSecondaryStagingStore") {}

        /// <summary>
        /// the URL for the staging store
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the details for the staging store
        /// </summary>
        public IDictionary<string, IDictionary<String, String>> Details { get; set; }

        /// <summary>
        /// the staging store provider name
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// the scope of the staging store: zone only for now
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the Zone ID for the staging store
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// create secondary staging store.
    /// </summary>
    /// <summary>
    /// create secondary staging store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse CreateSecondaryStagingStore(CreateSecondaryStagingStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse CreateSecondaryStagingStore(CreateSecondaryStagingStoreRequest request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
