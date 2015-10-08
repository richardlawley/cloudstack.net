using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetPasswordForVirtualMachineRequest : APIRequest
    {
        public ResetPasswordForVirtualMachineRequest() : base("resetPasswordForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Resets the password for virtual machine. The virtual machine must be in a "Stopped" state and the template must already support this feature for this command to take effect. [async]
    /// </summary>
    /// <summary>
    /// Resets the password for virtual machine. The virtual machine must be in a "Stopped" state and the template must already support this feature for this command to take effect. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
