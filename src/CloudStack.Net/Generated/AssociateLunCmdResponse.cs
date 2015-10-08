using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateLunCmdResponse
    {
        /// <summary>
        /// the LUN id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the IP address of 
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the target IQN
        /// </summary>
        public string TargetIQN { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
