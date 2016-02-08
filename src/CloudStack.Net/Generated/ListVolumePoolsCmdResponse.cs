using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumePoolsCmdResponse
    {
        /// <summary>
        /// pool id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// pool algorithm
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// pool name
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
