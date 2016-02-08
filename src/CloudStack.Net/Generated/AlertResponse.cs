using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AlertResponse
    {
        /// <summary>
        /// the id of the alert
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// description of the alert
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the alert
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the date and time the alert was sent
        /// </summary>
        public DateTime Sent { get; set; }

        /// <summary>
        /// One of the following alert types: MEMORY = 0, CPU = 1, STORAGE = 2, STORAGE_ALLOCATED = 3, PUBLIC_IP = 4, PRIVATE_IP = 5, HOST = 6, USERVM = 7, DOMAIN_ROUTER = 8, CONSOLE_PROXY = 9, ROUTING = 10: lost connection to default route (to the gateway), STORAGE_MISC = 11: lost connection to default route (to the gateway), USAGE_SERVER = 12: lost connection to default route (to the gateway), MANAGMENT_NODE = 13: lost connection to default route (to the gateway), DOMAIN_ROUTER_MIGRATE = 14, CONSOLE_PROXY_MIGRATE = 15, USERVM_MIGRATE = 16, VLAN = 17, SSVM = 18, USAGE_SERVER_RESULT = 19
        /// </summary>
        public short Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
