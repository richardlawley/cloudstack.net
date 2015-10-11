using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(ResourceId).ToLower()]; }
            set { Parameters[nameof(ResourceId).ToLower()] = value; }
        }

        /// <summary>
        /// Delete detail by resource type
        /// </summary>
        public string ResourceType {
            get { return (string) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

        /// <summary>
        /// Delete details matching key/value pairs
        /// </summary>
        public string Key {
            get { return (string) Parameters[nameof(Key).ToLower()]; }
            set { Parameters[nameof(Key).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes detail for the Resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveResourceDetail(RemoveResourceDetailRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveResourceDetail(RemoveResourceDetailRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
