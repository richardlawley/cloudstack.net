using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UcsManagerResponse
    {
        /// <summary>
        /// the ID of the ucs manager
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name of ucs manager
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the url of ucs manager
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the zone ID of ucs manager
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
