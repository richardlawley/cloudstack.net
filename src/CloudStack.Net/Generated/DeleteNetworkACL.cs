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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Network ACL
    /// </summary>
    /// <summary>
    /// Deletes a Network ACL
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
