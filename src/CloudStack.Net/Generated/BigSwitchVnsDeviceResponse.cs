using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BigSwitchVnsDeviceResponse
    {
        /// <summary>
        /// device name
        /// </summary>
        public string Bigswitchdevicename { get; set; }

        /// <summary>
        /// the controller Ip address
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the physical network to which this BigSwitch Vns belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// device id of the BigSwitch Vns
        /// </summary>
        public string Vnsdeviceid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
