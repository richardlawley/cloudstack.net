using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootSystemVmRequest : APIRequest
    {
        public RebootSystemVmRequest() : base("rebootSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Reboots a system VM.
    /// </summary>
    /// <summary>
    /// Reboots a system VM.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse RebootSystemVm(RebootSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse RebootSystemVm(RebootSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
