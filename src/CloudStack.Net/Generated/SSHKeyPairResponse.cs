using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SSHKeyPairResponse
    {
        /// <summary>
        /// the owner of the keypair
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the keypair owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the keypair owner
        /// </summary>
        public string DomainId { get; set; }

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
