using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTagsRequest : APIRequest
    {
        public DeleteTagsRequest() : base("deleteTags") {}

        /// <summary>
        /// Delete tags for resource id(s)
        /// </summary>
        public IList<string> ResourceIds {
            get { return GetList<string>(nameof(ResourceIds).ToLower()); }
            set { Parameters[nameof(ResourceIds).ToLower()] = value; }
        }

        /// <summary>
        /// Delete tag by resource type
        /// </summary>
        public string ResourceType {
            get { return (string) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

        /// <summary>
        /// Delete tags matching key/value pairs
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deleting resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTags(DeleteTagsRequest request);
        Task<AsyncJobResponse> DeleteTagsAsync(DeleteTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTags(DeleteTagsRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTagsAsync(DeleteTagsRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
