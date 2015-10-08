using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroySystemVmRequest : APIRequest
    {
        public DestroySystemVmRequest() : base("destroySystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Destroyes a system virtual machine.
    /// </summary>
    /// <summary>
    /// Destroyes a system virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse DestroySystemVm(DestroySystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse DestroySystemVm(DestroySystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
