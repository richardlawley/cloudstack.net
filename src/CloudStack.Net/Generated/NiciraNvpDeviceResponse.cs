using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NiciraNvpDeviceResponse
    {
        /// <summary>
        /// the controller Ip address
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// this L3 gateway service Uuid
        /// </summary>
        public string L3GatewayServiceUuid { get; set; }

        /// <summary>
        /// device name
        /// </summary>
        public string Niciradevicename { get; set; }

        /// <summary>
        /// device id of the Nicire Nvp
        /// </summary>
        public string Nvpdeviceid { get; set; }

        /// <summary>
        /// the physical network to which this Nirica Nvp belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the transport zone Uuid
        /// </summary>
        public string TransportZoneUuid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
