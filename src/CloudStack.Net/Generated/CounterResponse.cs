using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CounterResponse
    {
        /// <summary>
        /// the id of the Counter
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the counter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Value in case of snmp or other specific counters.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// zone id of counter
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
