using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LBHealthCheckResponse
    {
        /// <summary>
        /// the account of the HealthCheck policy
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain of the HealthCheck policy
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the HealthCheck policy
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the LB rule ID
        /// </summary>
        public string LbRuleId { get; set; }

        /// <summary>
        /// the id of the zone the HealthCheck policy belongs to
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the list of healthcheckpolicies
        /// </summary>
        public IList<LBHealthCheckPolicyResponse> Healthcheckpolicy { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
