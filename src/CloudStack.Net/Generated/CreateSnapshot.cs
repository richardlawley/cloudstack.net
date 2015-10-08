using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSnapshotRequest : APIRequest
    {
        public CreateSnapshotRequest() : base("createSnapshot") {}

        /// <summary>
        /// The ID of the disk volume
        /// </summary>
        public Guid VolumeId { get; set; }

        /// <summary>
        /// The account of the snapshot. The account parameter must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// The domain ID of the snapshot. If used with the account parameter, specifies a domain for the account associated with the disk volume.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the name of the snapshot
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// policy id of the snapshot, if this is null, then use MANUAL_POLICY.
        /// </summary>
        public Guid PolicyId { get; set; }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm { get; set; }

    }
    /// <summary>
    /// Creates an instant snapshot of a volume.
    /// </summary>
    /// <summary>
    /// Creates an instant snapshot of a volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SnapshotResponse CreateSnapshot(CreateSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SnapshotResponse CreateSnapshot(CreateSnapshotRequest request) => _proxy.Request<SnapshotResponse>(request);
    }
}
