using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapConfigurationResponse
    {
        /// <summary>
        /// hostname
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// port
        /// </summary>
        public int Port { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
