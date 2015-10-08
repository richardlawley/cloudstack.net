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
        public string ResourceId { get; set; }

        /// <summary>
        /// Delete detail by resource type
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Delete details matching key/value pairs
        /// </summary>
        public string Key { get; set; }

    }
    /// <summary>
    /// Removes detail for the Resource.
    /// </summary>
    /// <summary>
    /// Removes detail for the Resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveResourceDetail(RemoveResourceDetailRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveResourceDetail(RemoveResourceDetailRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
