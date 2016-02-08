using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NicSecondaryIpResponse
    {
        /// <summary>
        /// the ID of the secondary private IP addr
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Secondary IP address
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// the ID of the network
        /// </summary>
        public string Networkid { get; set; }

        /// <summary>
        /// the ID of the nic
        /// </summary>
        public string NicId { get; set; }

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public string Virtualmachineid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
