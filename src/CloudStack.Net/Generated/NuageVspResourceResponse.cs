using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NuageVspResourceResponse
    {
        /// <summary>
        /// the details of the Nuage VSP resource
        /// </summary>
        public string ResourceInfo { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
