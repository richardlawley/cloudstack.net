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
        public IList<string> ResourceIds { get; set; }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Map of tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tag { get; set; }

        /// <summary>
        /// identifies client specific tag. When the value is not null, the tag can't be used by cloudStack code internally
        /// </summary>
        public string Customer { get; set; }

    }
    /// <summary>
    /// Creates resource tag(s)
    /// </summary>
    /// <summary>
    /// Creates resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CreateTags(CreateTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CreateTags(CreateTagsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
