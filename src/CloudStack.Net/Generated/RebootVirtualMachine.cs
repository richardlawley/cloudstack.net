using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Reboots a virtual machine.
    /// </summary>
    /// <summary>
    /// Reboots a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RebootVirtualMachine(RebootVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RebootVirtualMachine(RebootVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
