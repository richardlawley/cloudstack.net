using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExternalFirewallResponse
    {
        /// <summary>
        /// the ID of the external firewall
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the management IP address of the external firewall
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the number of times to retry requests to the external firewall
        /// </summary>
        public string NumRetries { get; set; }

        /// <summary>
        /// the private interface of the external firewall
        /// </summary>
        public string PrivateInterface { get; set; }

        /// <summary>
        /// the private security zone of the external firewall
        /// </summary>
        public string PrivateZone { get; set; }

        /// <summary>
        /// the public interface of the external firewall
        /// </summary>
        public string PublicInterface { get; set; }

        /// <summary>
        /// the public security zone of the external firewall
        /// </summary>
        public string PublicZone { get; set; }

        /// <summary>
        /// the timeout (in seconds) for requests to the external firewall
        /// </summary>
        public string Timeout { get; set; }

        /// <summary>
        /// the usage interface of the external firewall
        /// </summary>
        public string UsageInterface { get; set; }

        /// <summary>
        /// the username that's used to log in to the external firewall
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the zone ID of the external firewall
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
