using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateSystemVmRequest : APIRequest
    {
        public MigrateSystemVmRequest() : base("migrateSystemVm") {}

        /// <summary>
        /// destination Host ID to migrate VM to
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    /// <summary>
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse MigrateSystemVm(MigrateSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse MigrateSystemVm(MigrateSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
