using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class Site2SiteVpnGatewayResponse
    {
        /// <summary>
        /// the vpn gateway ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is vpn gateway for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the project name
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the public IP address
        /// </summary>
        public string Publicip { get; set; }

        /// <summary>
        /// the date and time the host was removed
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// the vpc id of this gateway
        /// </summary>
        public string VpcId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
