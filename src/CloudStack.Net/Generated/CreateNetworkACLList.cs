using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkACLListRequest : APIRequest
    {
        public CreateNetworkACLListRequest() : base("createNetworkACLList") {}

        /// <summary>
        /// Name of the network ACL list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID of the VPC associated with this network ACL list
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// Description of the network ACL list
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional field, whether to the display the list to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Creates a network ACL for the given VPC
    /// </summary>
    /// <summary>
    /// Creates a network ACL for the given VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkACLResponse CreateNetworkACLList(CreateNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkACLResponse CreateNetworkACLList(CreateNetworkACLListRequest request) => _proxy.Request<NetworkACLResponse>(request);
    }
}
