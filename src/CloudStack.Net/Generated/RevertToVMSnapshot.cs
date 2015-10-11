using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// <summary>
    /// Revert VM from a vmsnapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RevertToVMSnapshot(RevertToVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RevertToVMSnapshot(RevertToVMSnapshotRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
