using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SnapshotPolicyResponse
    {
        /// <summary>
        /// the ID of the snapshot policy
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// is this policy for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the interval type of the snapshot policy
        /// </summary>
        public short IntervalType { get; set; }

        /// <summary>
        /// maximum number of snapshots retained
        /// </summary>
        public int MaxSnaps { get; set; }

        /// <summary>
        /// time the snapshot is scheduled to be taken.
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// the time zone of the snapshot policy
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public string VolumeId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
