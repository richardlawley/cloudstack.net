using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkACLRequest : APIRequest
    {
        public DeleteNetworkACLRequest() : base("deleteNetworkACL") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a network ACL
    /// </summary>
    /// <summary>
    /// Deletes a network ACL
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetworkACL(DeleteNetworkACLRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkACL(DeleteNetworkACLRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
