using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NuageVspDeviceResponse
    {
        /// <summary>
        /// the version of the API to use to communicate to Nuage VSD
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// the hostname of the Nuage VSD
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the name of the Nuage VSP device
        /// </summary>
        public string Nuagedevicename { get; set; }

        /// <summary>
        /// the ID of the physical network to which this Nuage VSP belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the port to communicate to Nuage VSD
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// the service provider name corresponding to this Nuage VSP device
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the number of retries on failure to communicate to Nuage VSD
        /// </summary>
        public int Retrycount { get; set; }

        /// <summary>
        /// the time to wait after failure before retrying to communicate to Nuage VSD
        /// </summary>
        public long Retryinterval { get; set; }

        /// <summary>
        /// the device id of the Nuage VSD
        /// </summary>
        public string Vspdeviceid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
