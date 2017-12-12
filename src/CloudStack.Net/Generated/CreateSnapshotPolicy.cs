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
            get { return GetParameterValue<string>(nameof(IntervalType).ToLower()); }
            set { SetParameterValue(nameof(IntervalType).ToLower(), value); }
        }

        /// <summary>
        /// maximum number of snapshots to retain
        /// </summary>
        public int? MaxSnaps {
            get { return GetParameterValue<int?>(nameof(MaxSnaps).ToLower()); }
            set { SetParameterValue(nameof(MaxSnaps).ToLower(), value); }
        }

        /// <summary>
        /// time the snapshot is scheduled to be taken. Format is:* if HOURLY, MM* if DAILY, MM:HH* if WEEKLY, MM:HH:DD (1-7)* if MONTHLY, MM:HH:DD (1-28)
        /// </summary>
        public string Schedule {
            get { return GetParameterValue<string>(nameof(Schedule).ToLower()); }
            set { SetParameterValue(nameof(Schedule).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return GetParameterValue<string>(nameof(Timezone).ToLower()); }
            set { SetParameterValue(nameof(Timezone).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId {
            get { return GetParameterValue<Guid>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the policy to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
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
        public SnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request) => Proxy.Request<SnapshotPolicyResponse>(request);
        public Task<SnapshotPolicyResponse> CreateSnapshotPolicyAsync(CreateSnapshotPolicyRequest request) => Proxy.RequestAsync<SnapshotPolicyResponse>(request);
    }
}
