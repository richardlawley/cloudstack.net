using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApplicationLoadBalancerRuleResponse
    {
        /// <summary>
        /// instance port of the load balancer rule
        /// </summary>
        public int InstancePort { get; set; }

        /// <summary>
        /// source port of the load balancer rule
        /// </summary>
        public int SourcePort { get; set; }

        /// <summary>
        /// the state of the load balancer rule
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
