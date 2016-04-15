using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RecoverVirtualMachineRequest : APIRequest
    {
        public RecoverVirtualMachineRequest() : base("recoverVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Recovers a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RecoverVirtualMachine(RecoverVirtualMachineRequest request);
        Task<UserVmResponse> RecoverVirtualMachineAsync(RecoverVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RecoverVirtualMachine(RecoverVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
        public Task<UserVmResponse> RecoverVirtualMachineAsync(RecoverVirtualMachineRequest request) => _proxy.RequestAsync<UserVmResponse>(request);
    }
}
