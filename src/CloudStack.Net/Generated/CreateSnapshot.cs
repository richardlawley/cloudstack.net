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
        public Guid VolumeId {
            get { return (Guid) Parameters[nameof(VolumeId).ToLower()]; }
            set { Parameters[nameof(VolumeId).ToLower()] = value; }
        }

        /// <summary>
        /// The account of the snapshot. The account parameter must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// The domain ID of the snapshot. If used with the account parameter, specifies a domain for the account associated with the disk volume.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// policy id of the snapshot, if this is null, then use MANUAL_POLICY.
        /// </summary>
        public Guid PolicyId {
            get { return (Guid) Parameters[nameof(PolicyId).ToLower()]; }
            set { Parameters[nameof(PolicyId).ToLower()] = value; }
        }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm {
            get { return (bool?) Parameters[nameof(Quiescevm).ToLower()]; }
            set { Parameters[nameof(Quiescevm).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates an instant snapshot of a volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateSnapshot(CreateSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateSnapshot(CreateSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
