using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddVmwareDcRequest : APIRequest
    {
        public AddVmwareDcRequest() : base("addVmwareDc") {}

        /// <summary>
        /// Name of VMware datacenter to be added to specified zone.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name/ip of vCenter. Make sure it is IP address or full qualified domain name for host running vCenter server.
        /// </summary>
        public string VCenter { get; set; }

        /// <summary>
        /// The Zone ID.
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// The password for specified username.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The Username required to connect to resource.
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a VMware datacenter to specified zone
    /// </summary>
    /// <summary>
    /// Adds a VMware datacenter to specified zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VmwareDatacenterResponse AddVmwareDc(AddVmwareDcRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VmwareDatacenterResponse AddVmwareDc(AddVmwareDcRequest request) => _proxy.Request<VmwareDatacenterResponse>(request);
    }
}
