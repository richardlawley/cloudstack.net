using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// If true is passed, the vm is expunged immediately. False by default.
        /// </summary>
        public bool? Expunge {
            get { return (bool?) Parameters[nameof(Expunge).ToLower()]; }
            set { Parameters[nameof(Expunge).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Destroys a virtual machine. Once destroyed, only the administrator can recover it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroyVirtualMachine(DestroyVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
