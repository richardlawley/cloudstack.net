using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateHostRequest : APIRequest
    {
        public UpdateHostRequest() : base("updateHost") {}

        /// <summary>
        /// the ID of the host to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Change resource state of host, valid values are [Enable, Disable]. Operation may failed if host in states not allowing Enable/Disable
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// list of tags to be added to the host
        /// </summary>
        public IList<string> HostTags { get; set; }

        /// <summary>
        /// the id of Os category to update the host with
        /// </summary>
        public Guid OsCategoryId { get; set; }

        /// <summary>
        /// the new uri for the secondary storage: nfs://host/path
        /// </summary>
        public string Url { get; set; }

    }
    /// <summary>
    /// Updates a host.
    /// </summary>
    /// <summary>
    /// Updates a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse UpdateHost(UpdateHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse UpdateHost(UpdateHostRequest request) => _proxy.Request<HostResponse>(request);
    }
}
