using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateHostResponse
    {
        /// <summary>
        /// the ID of the dedicated resource
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the Account ID of the host
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the Dedication Affinity Group ID of the host
        /// </summary>
        public string AffinityGroupId { get; set; }

        /// <summary>
        /// the domain ID of the host
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the host
        /// </summary>
        public string HostName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
