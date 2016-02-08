using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReplaceNetworkACLListRequest : APIRequest
    {
        public ReplaceNetworkACLListRequest() : base("replaceNetworkACLList") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid AclId {
            get { return (Guid) Parameters[nameof(AclId).ToLower()]; }
            set { Parameters[nameof(AclId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the private gateway
        /// </summary>
        public Guid Gatewayid {
            get { return (Guid) Parameters[nameof(Gatewayid).ToLower()]; }
            set { Parameters[nameof(Gatewayid).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Replaces ACL associated with a network or private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request);
        Task<AsyncJobResponse> ReplaceNetworkACLListAsync(ReplaceNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReplaceNetworkACLListAsync(ReplaceNetworkACLListRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
