using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TrafficMonitorResponse
    {
        /// <summary>
        /// the ID of the external firewall
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the management IP address of the external firewall
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the number of times to retry requests to the external firewall
        /// </summary>
        public string NumRetries { get; set; }

        /// <summary>
        /// the timeout (in seconds) for requests to the external firewall
        /// </summary>
        public string Timeout { get; set; }

        /// <summary>
        /// the zone ID of the external firewall
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
