using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TrafficTypeImplementorResponse
    {
        /// <summary>
        /// network traffic type
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// implementor of network traffic type
        /// </summary>
        public string Traffictypeimplementor { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
