using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDefaultNicForVirtualMachineRequest : APIRequest
    {
        public UpdateDefaultNicForVirtualMachineRequest() : base("updateDefaultNicForVirtualMachine") {}

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
    /// Changes the default NIC on a VM
    /// </summary>
    /// <summary>
    /// Changes the default NIC on a VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
