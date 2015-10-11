using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVirtualMachineRequest : APIRequest
    {
        public MigrateVirtualMachineRequest() : base("migrateVirtualMachine") {}

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// Destination Host ID to migrate VM to. Required for live migrating a VM from host to host
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// Destination storage pool ID to migrate VM volumes to. Required for migrating the root disk volume
        /// </summary>
        public Guid StorageId {
            get { return (Guid) Parameters[nameof(StorageId).ToLower()]; }
            set { Parameters[nameof(StorageId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Attempts Migration of a VM to a different host or Root volume of the vm to a different storage pool
    /// </summary>
    /// <summary>
    /// Attempts Migration of a VM to a different host or Root volume of the vm to a different storage pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse MigrateVirtualMachine(MigrateVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse MigrateVirtualMachine(MigrateVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
