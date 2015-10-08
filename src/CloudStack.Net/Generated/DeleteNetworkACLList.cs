using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkACLListRequest : APIRequest
    {
        public DeleteNetworkACLListRequest() : base("deleteNetworkACLList") {}

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
        SuccessResponse DeleteNetworkACLList(DeleteNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkACLList(DeleteNetworkACLListRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
