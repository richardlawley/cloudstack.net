using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LBStickinessPolicyResponse
    {
        /// <summary>
        /// the LB Stickiness policy ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the description of the Stickiness policy
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// is policy for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the method name of the Stickiness policy
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// the name of the Stickiness policy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the params of the policy
        /// </summary>
        public IDictionary<string, string> Params { get; set; }

        /// <summary>
        /// the state of the policy
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
