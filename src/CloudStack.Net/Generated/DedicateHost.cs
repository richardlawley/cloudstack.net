using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateHostRequest : APIRequest
    {
        public DedicateHostRequest() : base("dedicateHost") {}

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ID of the host to update
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

    }
    /// <summary>
    /// Dedicates a host.
    /// </summary>
    /// <summary>
    /// Dedicates a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DedicateHostResponse DedicateHost(DedicateHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DedicateHostResponse DedicateHost(DedicateHostRequest request) => _proxy.Request<DedicateHostResponse>(request);
    }
}
