using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedHostRequest : APIRequest
    {
        public ReleaseDedicatedHostRequest() : base("releaseDedicatedHost") {}

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Release the dedication for host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
