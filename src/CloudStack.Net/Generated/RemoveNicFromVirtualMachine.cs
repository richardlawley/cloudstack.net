using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveNicFromVirtualMachineRequest : APIRequest
    {
        public RemoveNicFromVirtualMachineRequest() : base("removeNicFromVirtualMachine") {}

        /// <summary>
        /// NIC ID
        /// </summary>
        public Guid NicId { get; set; }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid VmId { get; set; }

    }
    /// <summary>
    /// Removes VM from specified network by deleting a NIC
    /// </summary>
    /// <summary>
    /// Removes VM from specified network by deleting a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
