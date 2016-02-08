using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LBStickinessResponse
    {
        /// <summary>
        /// the account of the Stickiness policy
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the description of the Stickiness policy
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain of the Stickiness policy
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the Stickiness policy
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the LB rule ID
        /// </summary>
        public string LbRuleId { get; set; }

        /// <summary>
        /// the name of the Stickiness policy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the state of the policy
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the id of the zone the Stickiness policy belongs to
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the list of stickinesspolicies
        /// </summary>
        public IList<LBStickinessPolicyResponse> Stickinesspolicy { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
