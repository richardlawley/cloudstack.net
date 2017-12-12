using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetList<string>(nameof(ResourceIds).ToLower()); }
            set { SetParameterValue(nameof(ResourceIds).ToLower(), value); }
        }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

        /// <summary>
        /// Map of tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// identifies client specific tag. When the value is not null, the tag can't be used by cloudStack code internally
        /// </summary>
        public string Customer {
            get { return GetParameterValue<string>(nameof(Customer).ToLower()); }
            set { SetParameterValue(nameof(Customer).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTags(CreateTagsRequest request);
        Task<AsyncJobResponse> CreateTagsAsync(CreateTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTags(CreateTagsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTagsAsync(CreateTagsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
