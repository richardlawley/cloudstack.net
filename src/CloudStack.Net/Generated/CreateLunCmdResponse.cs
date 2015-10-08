using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLunCmdResponse
    {
        /// <summary>
        /// ip address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// iqn
        /// </summary>
        public string Iqn { get; set; }

        /// <summary>
        /// pool path
        /// </summary>
        public string Path { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
