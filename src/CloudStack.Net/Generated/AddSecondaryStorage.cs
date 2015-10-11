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
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the secondary storage
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
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
