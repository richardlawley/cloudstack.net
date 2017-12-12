using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootVirtualMachineRequest : APIRequest
    {
        public RebootVirtualMachineRequest() : base("rebootVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reboots a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RebootVirtualMachine(RebootVirtualMachineRequest request);
        Task<AsyncJobResponse> RebootVirtualMachineAsync(RebootVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RebootVirtualMachine(RebootVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RebootVirtualMachineAsync(RebootVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
