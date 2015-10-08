using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartSystemVmRequest : APIRequest
    {
        public StartSystemVmRequest() : base("startSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Starts a system virtual machine.
    /// </summary>
    /// <summary>
    /// Starts a system virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse StartSystemVm(StartSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse StartSystemVm(StartSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
