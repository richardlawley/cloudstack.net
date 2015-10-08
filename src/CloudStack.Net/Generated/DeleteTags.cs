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
        public IList<string> ResourceIds { get; set; }

        /// <summary>
        /// Delete tag by resource type
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Delete tags matching key/value pairs
        /// </summary>
        public IDictionary<string, string> Tag { get; set; }

    }
    /// <summary>
    /// Deleting resource tag(s)
    /// </summary>
    /// <summary>
    /// Deleting resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteTags(DeleteTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteTags(DeleteTagsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
