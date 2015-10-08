using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSnapshotRequest : APIRequest
    {
        public DeleteSnapshotRequest() : base("deleteSnapshot") {}

        /// <summary>
        /// The ID of the snapshot
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a snapshot of a disk volume.
    /// </summary>
    /// <summary>
    /// Deletes a snapshot of a disk volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSnapshot(DeleteSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSnapshot(DeleteSnapshotRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
