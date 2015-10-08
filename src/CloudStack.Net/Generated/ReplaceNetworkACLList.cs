using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReplaceNetworkACLListRequest : APIRequest
    {
        public ReplaceNetworkACLListRequest() : base("replaceNetworkACLList") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid AclId { get; set; }

        /// <summary>
        /// the ID of the private gateway
        /// </summary>
        public Guid PrivateGatewayId { get; set; }

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid NetworkId { get; set; }

    }
    /// <summary>
    /// Replaces ACL associated with a network or private gateway
    /// </summary>
    /// <summary>
    /// Replaces ACL associated with a network or private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
