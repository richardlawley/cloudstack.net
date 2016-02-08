using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HostTagResponse
    {
        /// <summary>
        /// the ID of the host tag
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the host ID of the host tag
        /// </summary>
        public long HostId { get; set; }

        /// <summary>
        /// the name of the host tag
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
