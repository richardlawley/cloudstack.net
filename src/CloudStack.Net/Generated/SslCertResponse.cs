using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SslCertResponse
    {
        /// <summary>
        /// SSL certificate ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// account for the certificate
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// certificate chain
        /// </summary>
        public string Certchain { get; set; }

        /// <summary>
        /// certificate
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// the domain name of the network owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the network owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// certificate fingerprint
        /// </summary>
        public string Fingerprint { get; set; }

        /// <summary>
        /// List of loabalancers this certificate is bound to
        /// </summary>
        public IList<string> Loadbalancerrulelist { get; set; }

        /// <summary>
        /// the project name of the certificate
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the certificate
        /// </summary>
        public string ProjectId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
