using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VmwareDatacenterResponse
    {
        /// <summary>
        /// The VMware Datacenter ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The VMware Datacenter name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The VMware vCenter name/ip
        /// </summary>
        public string VCenter { get; set; }

        /// <summary>
        /// the Zone ID associated with this VMware Datacenter
        /// </summary>
        public long ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
