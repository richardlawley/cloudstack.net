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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a vmsnapshot.
    /// </summary>
    /// <summary>
    /// Deletes a vmsnapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVMSnapshot(DeleteVMSnapshotRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
