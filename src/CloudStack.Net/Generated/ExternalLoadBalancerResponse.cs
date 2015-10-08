using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExternalLoadBalancerResponse
    {
        /// <summary>
        /// the ID of the external load balancer
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the management IP address of the external load balancer
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the number of times to retry requests to the external load balancer
        /// </summary>
        public string NumRetries { get; set; }

        /// <summary>
        /// the private interface of the external load balancer
        /// </summary>
        public string PrivateInterface { get; set; }

        /// <summary>
        /// the public interface of the external load balancer
        /// </summary>
        public string PublicInterface { get; set; }

        /// <summary>
        /// the username that's used to log in to the external load balancer
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the zone ID of the external load balancer
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
