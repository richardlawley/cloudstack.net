using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class OvsProviderResponse
    {
        /// <summary>
        /// the id of the ovs
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the provider
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain associated with the provider
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID associated with the provider
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// the physical network service provider id of the provider
        /// </summary>
        public string NspId { get; set; }

        /// <summary>
        /// the project name of the address
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the ipaddress
        /// </summary>
        public string ProjectId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
