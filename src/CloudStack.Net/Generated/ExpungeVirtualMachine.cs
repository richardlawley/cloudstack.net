using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Expunge a virtual machine. Once expunged, it cannot be recoverd.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
