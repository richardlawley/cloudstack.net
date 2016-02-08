using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VpnUsersResponse
    {
        /// <summary>
        /// the vpn userID
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
        /// the project name of the vpn
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vpn
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the state of the Vpn User
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the username of the vpn user
        /// </summary>
        public string UserName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
