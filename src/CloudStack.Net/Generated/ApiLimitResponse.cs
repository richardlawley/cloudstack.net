using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiLimitResponse
    {
        /// <summary>
        /// the account name of the api remaining count
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the account uuid of the api remaining count
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// currently allowed number of apis
        /// </summary>
        public int ApiAllowed { get; set; }

        /// <summary>
        /// number of api already issued
        /// </summary>
        public int ApiIssued { get; set; }

        /// <summary>
        /// seconds left to reset counters
        /// </summary>
        public long ExpireAfter { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
