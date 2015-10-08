using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVirtualMachineUserDataRequest : APIRequest
    {
        public GetVirtualMachineUserDataRequest() : base("getVirtualMachineUserData") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid VmId { get; set; }

    }
    /// <summary>
    /// Returns user data associated with the VM
    /// </summary>
    /// <summary>
    /// Returns user data associated with the VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VMUserDataResponse GetVirtualMachineUserData(GetVirtualMachineUserDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VMUserDataResponse GetVirtualMachineUserData(GetVirtualMachineUserDataRequest request) => _proxy.Request<VMUserDataResponse>(request);
    }
}
