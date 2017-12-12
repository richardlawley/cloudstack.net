using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyVirtualMachineRequest : APIRequest
    {
        public DestroyVirtualMachineRequest() : base("destroyVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If true is passed, the vm is expunged immediately. False by default.
        /// </summary>
        public bool? Expunge {
            get { return GetParameterValue<bool?>(nameof(Expunge).ToLower()); }
            set { SetParameterValue(nameof(Expunge).ToLower(), value); }
        }

    }
    /// <summary>
    /// Destroys a virtual machine. Once destroyed, only the administrator can recover it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request);
        Task<AsyncJobResponse> DestroyVirtualMachineAsync(DestroyVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DestroyVirtualMachineAsync(DestroyVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
