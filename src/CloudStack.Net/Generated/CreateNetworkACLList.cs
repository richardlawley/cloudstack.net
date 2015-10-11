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
        /// Name of the network ACL List
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Id of the VPC associated with this network ACL List
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// Description of the network ACL List
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the list to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a Network ACL for the given VPC
    /// </summary>
    /// <summary>
    /// Creates a Network ACL for the given VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateNetworkACLList(CreateNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateNetworkACLList(CreateNetworkACLListRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
