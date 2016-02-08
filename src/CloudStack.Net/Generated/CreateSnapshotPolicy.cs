using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSnapshotPolicyRequest : APIRequest
    {
        public CreateSnapshotPolicyRequest() : base("createSnapshotPolicy") {}

        /// <summary>
        /// valid values are HOURLY, DAILY, WEEKLY, and MONTHLY
        /// </summary>
        public string IntervalType {
            get { return (string) Parameters[nameof(IntervalType).ToLower()]; }
            set { Parameters[nameof(IntervalType).ToLower()] = value; }
        }

        /// <summary>
        /// maximum number of snapshots to retain
        /// </summary>
        public int MaxSnaps {
            get { return (int) Parameters[nameof(MaxSnaps).ToLower()]; }
            set { Parameters[nameof(MaxSnaps).ToLower()] = value; }
        }

        /// <summary>
        /// time the snapshot is scheduled to be taken. Format is:* if HOURLY, MM* if DAILY, MM:HH* if WEEKLY, MM:HH:DD (1-7)* if MONTHLY, MM:HH:DD (1-28)
        /// </summary>
        public string Schedule {
            get { return (string) Parameters[nameof(Schedule).ToLower()]; }
            set { Parameters[nameof(Schedule).ToLower()] = value; }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return (string) Parameters[nameof(Timezone).ToLower()]; }
            set { Parameters[nameof(Timezone).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId {
            get { return (Guid) Parameters[nameof(VolumeId).ToLower()]; }
            set { Parameters[nameof(VolumeId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the policy to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a snapshot policy for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request);
        Task<SnapshotPolicyResponse> CreateSnapshotPolicyAsync(CreateSnapshotPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request) => _proxy.Request<SnapshotPolicyResponse>(request);
        public Task<SnapshotPolicyResponse> CreateSnapshotPolicyAsync(CreateSnapshotPolicyRequest request) => _proxy.RequestAsync<SnapshotPolicyResponse>(request);
    }
}
