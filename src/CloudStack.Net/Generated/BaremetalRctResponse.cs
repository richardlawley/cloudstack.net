using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BaremetalRctResponse
    {
        /// <summary>
        /// id of rct
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// url
        /// </summary>
        public string Url { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
