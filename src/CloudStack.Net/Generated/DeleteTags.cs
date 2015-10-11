using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (IList<string>) Parameters[nameof(ResourceIds).ToLower()]; }
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
        public IDictionary<string, string> Tags {
            get { return (IDictionary<string, string>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deleting resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTags(DeleteTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTags(DeleteTagsRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
