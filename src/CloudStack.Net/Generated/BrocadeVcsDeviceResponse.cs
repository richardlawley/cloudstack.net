using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BrocadeVcsDeviceResponse
    {
        /// <summary>
        /// device name
        /// </summary>
        public string Brocadedevicename { get; set; }

        /// <summary>
        /// the principal switch Ip address
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the physical Network to which this Brocade VCS belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// device id of the Brocade Vcs
        /// </summary>
        public string Vcsdeviceid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
