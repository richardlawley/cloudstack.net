using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSnapshotRequest : APIRequest
    {
        public DeleteSnapshotRequest() : base("deleteSnapshot") {}

        /// <summary>
        /// The ID of the snapshot
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a snapshot of a disk volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteSnapshot(DeleteSnapshotRequest request);
        Task<AsyncJobResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteSnapshot(DeleteSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
