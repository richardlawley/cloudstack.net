using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalHostRequest : APIRequest
    {
        public AddBaremetalHostRequest() : base("addBaremetalHost") {}

        /// <summary>
        /// hypervisor type of the host
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the host URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the username for the host
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the Zone ID for the host
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// Allocation state of this Host for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the cluster ID for the host
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the cluster name for the host
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// list of tags to be added to the host
        /// </summary>
        public IList<string> HostTags { get; set; }

        /// <summary>
        /// ip address intentionally allocated to this host after provisioning
        /// </summary>
        public string VmIpAddress { get; set; }

    }
    /// <summary>
    /// add a baremetal host
    /// </summary>
    /// <summary>
    /// add a baremetal host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse AddBaremetalHost(AddBaremetalHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse AddBaremetalHost(AddBaremetalHostRequest request) => _proxy.Request<HostResponse>(request);
    }
}
