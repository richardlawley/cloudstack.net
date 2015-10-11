using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SSHKeyPairResponse
    {
        /// <summary>
        /// Fingerprint of the public key
        /// </summary>
        public string Fingerprint { get; set; }

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
