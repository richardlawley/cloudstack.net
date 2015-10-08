using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApplicationLoadBalancerInstanceResponse
    {
        /// <summary>
        /// the instance ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the ip address of the instance
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the name of the instance
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the state of the instance
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
