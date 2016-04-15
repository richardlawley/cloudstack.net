using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Vmsnapshotid).ToLower()); }
            set { SetParameterValue(nameof(Vmsnapshotid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a vmsnapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request);
        Task<AsyncJobResponse> DeleteVMSnapshotAsync(DeleteVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteVMSnapshotAsync(DeleteVMSnapshotRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
