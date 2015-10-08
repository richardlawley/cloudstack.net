using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopVirtualMachineRequest : APIRequest
    {
        public StopVirtualMachineRequest() : base("stopVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force stop the VM (vm is marked as Stopped even when command fails to be send to the backend).  The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced { get; set; }

    }
    /// <summary>
    /// Stops a virtual machine.
    /// </summary>
    /// <summary>
    /// Stops a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse StopVirtualMachine(StopVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse StopVirtualMachine(StopVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
