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
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// resource id to create the details for
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// pass false if you want this detail to be disabled for the regular user. True by default
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Adds detail for the Resource.
    /// </summary>
    /// <summary>
    /// Adds detail for the Resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AddResourceDetail(AddResourceDetailRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AddResourceDetail(AddResourceDetailRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
