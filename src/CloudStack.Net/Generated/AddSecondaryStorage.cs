using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the secondary storage
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds secondary storage.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddSecondaryStorage(AddSecondaryStorageRequest request);
        Task<ImageStoreResponse> AddSecondaryStorageAsync(AddSecondaryStorageRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddSecondaryStorage(AddSecondaryStorageRequest request) => _proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> AddSecondaryStorageAsync(AddSecondaryStorageRequest request) => _proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
