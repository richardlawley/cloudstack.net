using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BigSwitchBcfDeviceResponse
    {
        /// <summary>
        /// device id of the BigSwitch BCF Controller
        /// </summary>
        public string Bcfdeviceid { get; set; }

        /// <summary>
        /// device name
        /// </summary>
        public string Bigswitchdevicename { get; set; }

        /// <summary>
        /// the controller Ip address
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// NAT support
        /// </summary>
        public bool Nat { get; set; }

        /// <summary>
        /// the controller password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the physical network to which this BigSwitch BCF segment belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the controller username
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
