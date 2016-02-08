using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SspResponse
    {
        /// <summary>
        /// server id of the stratosphere ssp server
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// url of ssp endpoint
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// zone which this ssp controls
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
