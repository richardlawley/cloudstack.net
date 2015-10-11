using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVirtualMachineWithVolumeRequest : APIRequest
    {
        public MigrateVirtualMachineWithVolumeRequest() : base("migrateVirtualMachineWithVolume") {}

        /// <summary>
        /// Destination Host ID to migrate VM to.
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

        /// <summary>
        /// Map of pool to which each volume should be migrated (volume/pool pair)
        /// </summary>
        public IList<IDictionary<string, object>> Migrateto {
            get { return GetList<IDictionary<string, object>>(nameof(Migrateto).ToLower()); }
            set { Parameters[nameof(Migrateto).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Attempts Migration of a VM with its volumes to a different host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
