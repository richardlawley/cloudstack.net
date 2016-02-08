using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AutoScalePolicyResponse
    {
        /// <summary>
        /// the autoscale policy ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the autoscale policy
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the action to be executed if all the conditions evaluate to true for the specified duration.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the list of IDs of the conditions that are being evaluated on every interval
        /// </summary>
        public IList<ConditionResponse> Conditions { get; set; }

        /// <summary>
        /// the domain name of the autoscale policy
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the autoscale policy
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the duration for which the conditions have to be true before action is taken
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// the project name of the autoscale policy
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id autoscale policy
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the cool down period for which the policy should not be evaluated after the action has been taken
        /// </summary>
        public int QuietTime { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
