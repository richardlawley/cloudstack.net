using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// Map of pool to which each volume should be migrated (volume/pool pair)
        /// </summary>
        public IList<IDictionary<string, object>> Migrateto {
            get { return GetList<IDictionary<string, object>>(nameof(Migrateto).ToLower()); }
            set { SetParameterValue(nameof(Migrateto).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attempts Migration of a VM with its volumes to a different host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request);
        Task<AsyncJobResponse> MigrateVirtualMachineWithVolumeAsync(MigrateVirtualMachineWithVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateVirtualMachineWithVolumeAsync(MigrateVirtualMachineWithVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
