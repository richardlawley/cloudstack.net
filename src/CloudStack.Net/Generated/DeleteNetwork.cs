using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkRequest : APIRequest
    {
        public DeleteNetworkRequest() : base("deleteNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force delete a network. Network will be marked as 'Destroy' even when commands to shutdown and cleanup to the backend fails.
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a network
    /// </summary>
    /// <summary>
    /// Deletes a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNetwork(DeleteNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetwork(DeleteNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
