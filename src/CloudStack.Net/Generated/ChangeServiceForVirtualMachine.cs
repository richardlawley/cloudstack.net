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
        public Guid Id { get; set; }

        /// <summary>
        /// the service offering ID to apply to the virtual machine
        /// </summary>
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// name value pairs of custom parameters for cpu, memory and cpunumber. example details[i].name=value
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

    }
    /// <summary>
    /// Changes the service offering for a virtual machine. The virtual machine must be in a "Stopped" state for this command to take effect.
    /// </summary>
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
