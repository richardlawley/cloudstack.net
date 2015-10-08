using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ServiceResponse
    {
        /// <summary>
        /// the service name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the list of capabilities
        /// </summary>
        public IList<CapabilityResponse> Capability { get; set; }

        /// <summary>
        /// the service provider name
        /// </summary>
        public IList<ProviderResponse> Provider { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
