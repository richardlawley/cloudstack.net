using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddResourceDetailRequest : APIRequest
    {
        public AddResourceDetailRequest() : base("addResourceDetail") {}

        /// <summary>
        /// Map of (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// resource id to create the details for
        /// </summary>
        public string ResourceId {
            get { return (string) Parameters[nameof(ResourceId).ToLower()]; }
            set { Parameters[nameof(ResourceId).ToLower()] = value; }
        }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType {
            get { return (string) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

        /// <summary>
        /// pass false if you want this detail to be disabled for the regular user. True by default
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds detail for the Resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddResourceDetail(AddResourceDetailRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddResourceDetail(AddResourceDetailRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
