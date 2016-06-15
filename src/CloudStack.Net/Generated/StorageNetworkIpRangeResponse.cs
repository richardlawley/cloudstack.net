using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StorageNetworkIpRangeResponse
    {
        /// <summary>
        /// the uuid of storage network IP range.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the end ip of the storage network IP range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the gateway of the storage network IP range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the netmask of the storage network IP range
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the network uuid of storage network IP range
        /// </summary>
        public string Networkid { get; set; }

        /// <summary>
        /// the Pod uuid for the storage network IP range
        /// </summary>
        public string Podid { get; set; }

        /// <summary>
        /// the start ip of the storage network IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the ID or VID of the VLAN.
        /// </summary>
        public int? Vlan { get; set; }

        /// <summary>
        /// the Zone uuid of the storage network IP range
        /// </summary>
        public string Zoneid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
