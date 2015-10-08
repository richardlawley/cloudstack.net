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
        public Guid HostId { get; set; }

    }
    /// <summary>
    /// Release the dedication for host
    /// </summary>
    /// <summary>
    /// Release the dedication for host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
