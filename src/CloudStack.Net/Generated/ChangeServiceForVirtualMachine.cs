using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeServiceForVirtualMachineRequest : APIRequest
    {
        public ChangeServiceForVirtualMachineRequest() : base("changeServiceForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the service offering ID to apply to the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpu, memory and cpunumber. example details[i].name=value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Changes the service offering for a virtual machine. The virtual machine must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
