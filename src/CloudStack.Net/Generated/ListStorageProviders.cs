using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageProvidersRequest : APIRequest
    {
        public ListStorageProvidersRequest() : base("listStorageProviders") {}

        /// <summary>
        /// the type of storage provider: either primary or image
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists storage providers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageProviderResponse> ListStorageProviders(ListStorageProvidersRequest request) => _proxy.Request<ListResponse<StorageProviderResponse>>(request);
    }
}
