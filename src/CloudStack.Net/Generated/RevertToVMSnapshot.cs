using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevertToVMSnapshotRequest : APIRequest
    {
        public RevertToVMSnapshotRequest() : base("revertToVMSnapshot") {}

        /// <summary>
        /// The ID of the vm snapshot
        /// </summary>
        public Guid VmSnapShotId {
            get { return (Guid) Parameters[nameof(VmSnapShotId).ToLower()]; }
            set { Parameters[nameof(VmSnapShotId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Revert VM from a vmsnapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevertToVMSnapshot(RevertToVMSnapshotRequest request);
        Task<AsyncJobResponse> RevertToVMSnapshotAsync(RevertToVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevertToVMSnapshot(RevertToVMSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RevertToVMSnapshotAsync(RevertToVMSnapshotRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
