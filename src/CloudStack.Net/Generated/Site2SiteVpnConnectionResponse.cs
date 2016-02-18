using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class Site2SiteVpnConnectionResponse
    {
        /// <summary>
        /// the connection ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// guest cidr list of the customer gateway
        /// </summary>
        public string Cidrlist { get; set; }

        /// <summary>
        /// the date and time the host was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the domain name of the owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// if DPD is enabled for customer gateway
        /// </summary>
        public bool Dpd { get; set; }

        /// <summary>
        /// Lifetime of ESP SA of customer gateway
        /// </summary>
        public long EspLifetime { get; set; }

        /// <summary>
        /// ESP policy of the customer gateway
        /// </summary>
        public string EspPolicy { get; set; }

        /// <summary>
        /// if Force NAT Encapsulation is enabled for customer gateway
        /// </summary>
        public bool Forceencap { get; set; }

        /// <summary>
        /// is connection for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// public ip address id of the customer gateway
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Lifetime of IKE SA of customer gateway
        /// </summary>
        public long IkeLifetime { get; set; }

        /// <summary>
        /// IKE policy of the customer gateway
        /// </summary>
        public string IkePolicy { get; set; }

        /// <summary>
        /// IPsec Preshared-Key of the customer gateway
        /// </summary>
        public string IpsecPsk { get; set; }

        /// <summary>
        /// State of vpn connection
        /// </summary>
        public bool Passive { get; set; }

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
        /// the customer gateway ID
        /// </summary>
        public string S2scustomergatewayid { get; set; }

        /// <summary>
        /// the vpn gateway ID
        /// </summary>
        public string S2svpngatewayid { get; set; }

        /// <summary>
        /// State of vpn connection
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
