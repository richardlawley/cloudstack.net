using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CloudIdentifierResponse
    {
        /// <summary>
        /// the cloud identifier
        /// </summary>
        public string CloudIdentifier { get; set; }

        /// <summary>
        /// the signed response for the cloud identifier
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// the user ID for the cloud identifier
        /// </summary>
        public string UserId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
