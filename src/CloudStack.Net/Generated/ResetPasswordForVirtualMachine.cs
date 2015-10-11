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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Resets the password for virtual machine. The virtual machine must be in a "Stopped" state and the template must already support this feature for this command to take effect. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
