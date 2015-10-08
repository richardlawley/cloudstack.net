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
        public Guid HostId { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// Map of pool to which each volume should be migrated (volume/pool pair)
        /// </summary>
        public IDictionary<string, string> MigrateVolumeTo { get; set; }

    }
    /// <summary>
    /// Attempts Migration of a VM with its volumes to a different host
    /// </summary>
    /// <summary>
    /// Attempts Migration of a VM with its volumes to a different host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
