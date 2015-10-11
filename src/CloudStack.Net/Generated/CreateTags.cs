using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTagsRequest : APIRequest
    {
        public CreateTagsRequest() : base("createTags") {}

        /// <summary>
        /// list of resources to create the tags for
        /// </summary>
        public IList<string> ResourceIds {
            get { return (IList<string>) Parameters[nameof(ResourceIds).ToLower()]; }
            set { Parameters[nameof(ResourceIds).ToLower()] = value; }
        }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType {
            get { return (string) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

        /// <summary>
        /// Map of tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags {
            get { return (IDictionary<string, string>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// identifies client specific tag. When the value is not null, the tag can't be used by cloudStack code internally
        /// </summary>
        public string Customer {
            get { return (string) Parameters[nameof(Customer).ToLower()]; }
            set { Parameters[nameof(Customer).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTags(CreateTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTags(CreateTagsRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
