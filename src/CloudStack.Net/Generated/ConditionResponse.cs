using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConditionResponse
    {
        /// <summary>
        /// the id of the Condition
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner of the Condition.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Details of the Counter.
        /// </summary>
        public IList<CounterResponse> Counter { get; set; }

        /// <summary>
        /// the domain name of the owner.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the Condition owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the project name of the Condition
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the Condition.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Relational Operator to be used with threshold.
        /// </summary>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// Threshold Value for the counter.
        /// </summary>
        public long Threshold { get; set; }

        /// <summary>
        /// zone id of counter
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
