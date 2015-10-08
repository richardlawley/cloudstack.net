using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyVirtualMachineRequest : APIRequest
    {
        public DestroyVirtualMachineRequest() : base("destroyVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// If true is passed, the vm is expunged immediately. False by default.
        /// </summary>
        public bool? Expunge { get; set; }

    }
    /// <summary>
    /// Destroys a virtual machine. Once destroyed, only the administrator can recover it.
    /// </summary>
    /// <summary>
    /// Destroys a virtual machine. Once destroyed, only the administrator can recover it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
