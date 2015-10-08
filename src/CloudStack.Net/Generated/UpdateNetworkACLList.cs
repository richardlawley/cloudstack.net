using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkACLListRequest : APIRequest
    {
        public UpdateNetworkACLListRequest() : base("updateNetworkACLList") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the list to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates network ACL list
    /// </summary>
    /// <summary>
    /// Updates network ACL list
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateNetworkACLList(UpdateNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateNetworkACLList(UpdateNetworkACLListRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
