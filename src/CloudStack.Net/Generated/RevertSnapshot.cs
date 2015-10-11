using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevertSnapshotRequest : APIRequest
    {
        public RevertSnapshotRequest() : base("revertSnapshot") {}

        /// <summary>
        /// The ID of the snapshot
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// revert a volume snapshot.
    /// </summary>
    /// <summary>
    /// revert a volume snapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SnapshotResponse RevertSnapshot(RevertSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SnapshotResponse RevertSnapshot(RevertSnapshotRequest request) => _proxy.Request<SnapshotResponse>(request);
    }
}
