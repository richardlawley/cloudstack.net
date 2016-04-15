using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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

    }
    /// <summary>
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request);
        Task<AsyncJobResponse> MigrateSystemVmAsync(MigrateSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateSystemVmAsync(MigrateSystemVmRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
