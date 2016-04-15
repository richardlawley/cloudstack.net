using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDefaultNicForVirtualMachineRequest : APIRequest
    {
        public UpdateDefaultNicForVirtualMachineRequest() : base("updateDefaultNicForVirtualMachine") {}

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
    /// Changes the default NIC on a VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request);
        Task<AsyncJobResponse> UpdateDefaultNicForVirtualMachineAsync(UpdateDefaultNicForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateDefaultNicForVirtualMachineAsync(UpdateDefaultNicForVirtualMachineRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
