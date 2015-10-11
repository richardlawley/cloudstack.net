using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DomainResponse
    {
        /// <summary>
        /// the ID of the domain
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// whether the domain has one or more sub-domains
        /// </summary>
        public bool HasChild { get; set; }

        /// <summary>
        /// the level of the domain
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// the name of the domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the domain ID of the parent domain
        /// </summary>
        public string ParentDomainId { get; set; }

        /// <summary>
        /// the domain name of the parent domain
        /// </summary>
        public string ParentDomainName { get; set; }

        /// <summary>
        /// the path of the domain
        /// </summary>
        public string Path { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
