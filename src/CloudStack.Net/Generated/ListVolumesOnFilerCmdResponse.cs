using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesOnFilerCmdResponse
    {
        /// <summary>
        /// volume id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Aggregate name
        /// </summary>
        public string Aggregatename { get; set; }

        /// <summary>
        /// ip address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// pool name
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// volume size
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// snapshot policy
        /// </summary>
        public string SnapshotPolicy { get; set; }

        /// <summary>
        /// snapshot reservation
        /// </summary>
        public int SnapshotReservation { get; set; }

        /// <summary>
        /// Volume name
        /// </summary>
        public string VolumeName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
