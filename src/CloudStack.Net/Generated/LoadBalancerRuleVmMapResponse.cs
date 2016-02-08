using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LoadBalancerRuleVmMapResponse
    {
        /// <summary>
        /// IP addresses of the vm set of lb rule
        /// </summary>
        public IList<string> Lbvmipaddresses { get; set; }

        /// <summary>
        /// the user vm set for lb rule
        /// </summary>
        public UserVmResponse Loadbalancerruleinstance { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
