using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaStatementItemResponse
    {
        /// <summary>
        /// account name
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// account id
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// domain id
        /// </summary>
        public long Domain { get; set; }

        /// <summary>
        /// usage type name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// quota consumed
        /// </summary>
        public decimal Quota { get; set; }

        /// <summary>
        /// usage type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// usage unit
        /// </summary>
        public string Unit { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
