using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVMSnapshotRequest : APIRequest
    {
        public DeleteVMSnapshotRequest() : base("deleteVMSnapshot") {}

        /// <summary>
        /// The ID of the VM snapshot
        /// </summary>
        public Guid Vmsnapshotid {
            get { return (Guid) Parameters[nameof(Vmsnapshotid).ToLower()]; }
            set { Parameters[nameof(Vmsnapshotid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a vmsnapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
