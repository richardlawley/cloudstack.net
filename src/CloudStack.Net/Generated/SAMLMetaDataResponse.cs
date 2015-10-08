using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SAMLMetaDataResponse
    {
        /// <summary>
        /// The Metadata XML
        /// </summary>
        public string Metadata { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
