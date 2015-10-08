using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class OpenDaylightControllerResponse
    {
        /// <summary>
        /// device id of the controller
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name assigned to the controller
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the physical network to which this controller belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the url of the controller api
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the username to authenticate to the controller
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
