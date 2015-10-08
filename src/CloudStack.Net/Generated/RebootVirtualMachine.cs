using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootVirtualMachineRequest : APIRequest
    {
        public RebootVirtualMachineRequest() : base("rebootVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Reboots a virtual machine.
    /// </summary>
    /// <summary>
    /// Reboots a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RebootVirtualMachine(RebootVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RebootVirtualMachine(RebootVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
