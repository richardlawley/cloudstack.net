using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSnapshotPolicyRequest : APIRequest
    {
        public CreateSnapshotPolicyRequest() : base("createSnapshotPolicy") {}

        /// <summary>
        /// valid values are HOURLY, DAILY, WEEKLY, and MONTHLY
        /// </summary>
        public string IntervalType { get; set; }

        /// <summary>
        /// maximum number of snapshots to retain
        /// </summary>
        public int MaxSnaps { get; set; }

        /// <summary>
        /// time the snapshot is scheduled to be taken. Format is:* if HOURLY, MM* if DAILY, MM:HH* if WEEKLY, MM:HH:DD (1-7)* if MONTHLY, MM:HH:DD (1-28)
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the policy to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Creates a snapshot policy for the account.
    /// </summary>
    /// <summary>
    /// Creates a snapshot policy for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request) => _proxy.Request<SnapshotPolicyResponse>(request);
    }
}
