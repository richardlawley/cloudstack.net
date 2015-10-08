using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopSystemVmRequest : APIRequest
    {
        public StopSystemVmRequest() : base("stopSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force stop the VM.  The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced { get; set; }

    }
    /// <summary>
    /// Stops a system VM.
    /// </summary>
    /// <summary>
    /// Stops a system VM.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse StopSystemVm(StopSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse StopSystemVm(StopSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
