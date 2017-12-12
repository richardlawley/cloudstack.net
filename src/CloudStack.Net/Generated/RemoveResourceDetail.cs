using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveResourceDetailRequest : APIRequest
    {
        public RemoveResourceDetailRequest() : base("removeResourceDetail") {}

        /// <summary>
        /// Delete details for resource id
        /// </summary>
        public string ResourceId {
            get { return GetParameterValue<string>(nameof(ResourceId).ToLower()); }
            set { SetParameterValue(nameof(ResourceId).ToLower(), value); }
        }

        /// <summary>
        /// Delete detail by resource type
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

        /// <summary>
        /// Delete details matching key/value pairs
        /// </summary>
        public string Key {
            get { return GetParameterValue<string>(nameof(Key).ToLower()); }
            set { SetParameterValue(nameof(Key).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes detail for the Resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveResourceDetail(RemoveResourceDetailRequest request);
        Task<AsyncJobResponse> RemoveResourceDetailAsync(RemoveResourceDetailRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveResourceDetail(RemoveResourceDetailRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveResourceDetailAsync(RemoveResourceDetailRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
