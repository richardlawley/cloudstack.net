using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Resets the password for virtual machine. The virtual machine must be in a "Stopped" state and the template must already support this feature for this command to take effect. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request);
        Task<AsyncJobResponse> ResetPasswordForVirtualMachineAsync(ResetPasswordForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetPasswordForVirtualMachine(ResetPasswordForVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ResetPasswordForVirtualMachineAsync(ResetPasswordForVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
