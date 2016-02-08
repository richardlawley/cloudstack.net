using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoteAccessVpnResponse
    {
        /// <summary>
        /// the id of the remote access vpn
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the remote access vpn
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the account of the remote access vpn
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the account of the remote access vpn
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is vpn for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the range of ips to allocate to the clients
        /// </summary>
        public string IpRange { get; set; }

        /// <summary>
        /// the ipsec preshared key
        /// </summary>
        public string PresharedKey { get; set; }

        /// <summary>
        /// the project name of the vpn
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vpn
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the public ip address of the vpn server
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// the public ip address of the vpn server
        /// </summary>
        public string PublicIpId { get; set; }

        /// <summary>
        /// the state of the rule
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
