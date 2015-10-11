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
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// The name/ip of vCenter. Make sure it is IP address or full qualified domain name for host running vCenter server.
        /// </summary>
        public string VCenter {
            get { return (string) Parameters[nameof(VCenter).ToLower()]; }
            set { Parameters[nameof(VCenter).ToLower()] = value; }
        }

        /// <summary>
        /// The Zone ID.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// The password for specified username.
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// The Username required to connect to resource.
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
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
