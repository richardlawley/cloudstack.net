using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(NicId).ToLower()]; }
            set { Parameters[nameof(NicId).ToLower()] = value; }
        }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Changes the default NIC on a VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateDefaultNicForVirtualMachine(UpdateDefaultNicForVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
