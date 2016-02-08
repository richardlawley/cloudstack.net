using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CapabilityResponse
    {
        /// <summary>
        /// can this service capability value can be choosable while creatine network offerings
        /// </summary>
        public bool Canchooseservicecapability { get; set; }

        /// <summary>
        /// the capability name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the capability value
        /// </summary>
        public string Value { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
