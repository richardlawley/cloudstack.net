using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CapacityResponse
    {
        /// <summary>
        /// the total capacity available
        /// </summary>
        public long CapacityTotal { get; set; }

        /// <summary>
        /// the capacity currently in use
        /// </summary>
        public long CapacityUsed { get; set; }

        /// <summary>
        /// the Cluster ID
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// the Cluster name
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// the percentage of capacity currently in use
        /// </summary>
        public string PercentUsed { get; set; }

        /// <summary>
        /// the Pod ID
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Pod name
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the capacity type
        /// </summary>
        public short Type { get; set; }

        /// <summary>
        /// the Zone ID
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
