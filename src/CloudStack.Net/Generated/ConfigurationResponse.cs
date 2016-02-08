using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurationResponse
    {
        /// <summary>
        /// the value of the configuration
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// the category of the configuration
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// the description of the configuration
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the configuration
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// scope(zone/cluster/pool/account) of the parameter that needs to be updated
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the value of the configuration
        /// </summary>
        public string Value { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
