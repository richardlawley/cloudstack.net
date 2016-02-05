using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaSummaryResponse
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
        /// account balance
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// domain id
        /// </summary>
        public long DomainId { get; set; }

        /// <summary>
        /// end date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// quota usage of this period
        /// </summary>
        public decimal Quota { get; set; }

        /// <summary>
        /// start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// account state
        /// </summary>
        public AccountState State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
