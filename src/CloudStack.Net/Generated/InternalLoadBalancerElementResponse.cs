using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class InternalLoadBalancerElementResponse
    {
        /// <summary>
        /// the id of the internal load balancer element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Enabled/Disabled the element
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// the physical network service provider id of the element
        /// </summary>
        public string NspId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
