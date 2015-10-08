using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddImageStoreRequest : APIRequest
    {
        public AddImageStoreRequest() : base("addImageStore") {}

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

        /// <summary>
        /// the Zone ID for the image store
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Adds backup image store.
    /// </summary>
    /// <summary>
    /// Adds backup image store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddImageStore(AddImageStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddImageStore(AddImageStoreRequest request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
