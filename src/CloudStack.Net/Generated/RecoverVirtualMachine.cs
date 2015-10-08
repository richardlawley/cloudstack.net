using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RecoverVirtualMachineRequest : APIRequest
    {
        public RecoverVirtualMachineRequest() : base("recoverVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Recovers a virtual machine.
    /// </summary>
    /// <summary>
    /// Recovers a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RecoverVirtualMachine(RecoverVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RecoverVirtualMachine(RecoverVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
