using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The name/ip of vCenter. Make sure it is IP address or full qualified domain name for host running vCenter server.
        /// </summary>
        public string VCenter {
            get { return GetParameterValue<string>(nameof(VCenter).ToLower()); }
            set { SetParameterValue(nameof(VCenter).ToLower(), value); }
        }

        /// <summary>
        /// The Zone ID.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// The password for specified username.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// The Username required to connect to resource.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a VMware datacenter to specified zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VmwareDatacenterResponse AddVmwareDc(AddVmwareDcRequest request);
        Task<VmwareDatacenterResponse> AddVmwareDcAsync(AddVmwareDcRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VmwareDatacenterResponse AddVmwareDc(AddVmwareDcRequest request) => _proxy.Request<VmwareDatacenterResponse>(request);
        public Task<VmwareDatacenterResponse> AddVmwareDcAsync(AddVmwareDcRequest request) => _proxy.RequestAsync<VmwareDatacenterResponse>(request);
    }
}
