using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegionResponse
    {
        /// <summary>
        /// the ID of the region
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the end point of the region
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// true if GSLB service is enabled in the region, false otherwise
        /// </summary>
        public bool GslbServiceEnabled { get; set; }

        /// <summary>
        /// the name of the region
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// true if security groups support is enabled, false otherwise
        /// </summary>
        public bool PortableipServiceEnabled { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
