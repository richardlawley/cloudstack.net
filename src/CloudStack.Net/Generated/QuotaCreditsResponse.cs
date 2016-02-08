using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaCreditsResponse
    {
        /// <summary>
        /// the credit deposited
        /// </summary>
        public decimal Credits { get; set; }

        /// <summary>
        /// currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// the user name of the admin who updated the credits
        /// </summary>
        public string Updated_by { get; set; }

        /// <summary>
        /// the account name of the admin who updated the credits
        /// </summary>
        public DateTime Updated_on { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
