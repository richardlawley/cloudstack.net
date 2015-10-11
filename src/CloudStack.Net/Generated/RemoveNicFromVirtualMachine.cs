using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Removes VM from specified network by deleting a NIC
    /// </summary>
    /// <summary>
    /// Removes VM from specified network by deleting a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveNicFromVirtualMachine(RemoveNicFromVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
