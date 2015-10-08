using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddSecondaryStorageRequest : APIRequest
    {
        public AddSecondaryStorageRequest() : base("addSecondaryStorage") {}

        /// <summary>
        /// the URL for the secondary storage
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the Zone ID for the secondary storage
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Adds secondary storage.
    /// </summary>
    /// <summary>
    /// Adds secondary storage.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddSecondaryStorage(AddSecondaryStorageRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddSecondaryStorage(AddSecondaryStorageRequest request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
