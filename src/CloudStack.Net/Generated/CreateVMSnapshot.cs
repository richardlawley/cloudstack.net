using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVMSnapshotRequest : APIRequest
    {
        public CreateVMSnapshotRequest() : base("createVMSnapshot") {}

        /// <summary>
        /// The ID of the vm
        /// </summary>
        public Guid VmId { get; set; }

        /// <summary>
        /// The description of the snapshot
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The display name of the snapshot
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm { get; set; }

        /// <summary>
        /// snapshot memory if true
        /// </summary>
        public bool? SnapshotMemory { get; set; }

    }
    /// <summary>
    /// Creates snapshot for a vm.
    /// </summary>
    /// <summary>
    /// Creates snapshot for a vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VMSnapshotResponse CreateVMSnapshot(CreateVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VMSnapshotResponse CreateVMSnapshot(CreateVMSnapshotRequest request) => _proxy.Request<VMSnapshotResponse>(request);
    }
}
