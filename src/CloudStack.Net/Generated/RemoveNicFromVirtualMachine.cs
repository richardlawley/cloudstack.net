using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveNicFromVirtualMachineRequest : APIRequest
    {
        public RemoveNicFromVirtualMachineRequest() : base("removeNicFromVirtualMachine") {}

        /// <summary>
        /// NIC ID
        /// </summary>
        public Guid NicId {
            get { return GetParameterValue<Guid>(nameof(NicId).ToLower()); }
            set { SetParameterValue(nameof(NicId).ToLower(), value); }
        }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes VM from specified network by deleting a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request);
        Task<AsyncJobResponse> RemoveNicFromVirtualMachineAsync(RemoveNicFromVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveNicFromVirtualMachineAsync(RemoveNicFromVirtualMachineRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
