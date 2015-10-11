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
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    /// <summary>
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
