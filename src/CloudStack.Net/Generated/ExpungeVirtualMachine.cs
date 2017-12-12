using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExpungeVirtualMachineRequest : APIRequest
    {
        public ExpungeVirtualMachineRequest() : base("expungeVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Expunge a virtual machine. Once expunged, it cannot be recoverd.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request);
        Task<AsyncJobResponse> ExpungeVirtualMachineAsync(ExpungeVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ExpungeVirtualMachineAsync(ExpungeVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
