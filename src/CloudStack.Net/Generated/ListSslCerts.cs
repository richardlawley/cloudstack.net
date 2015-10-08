using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSslCertsRequest : APIRequest
    {
        public ListSslCertsRequest() : base("listSslCerts") {}

        /// <summary>
        /// Account ID
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// ID of SSL certificate
        /// </summary>
        public Guid CertId { get; set; }

        /// <summary>
        /// Load balancer rule ID
        /// </summary>
        public Guid LbId { get; set; }

        /// <summary>
        /// Project that owns the SSL certificate
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Lists SSL certificates
    /// </summary>
    /// <summary>
    /// Lists SSL certificates
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SslCertResponse ListSslCerts(ListSslCertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SslCertResponse ListSslCerts(ListSslCertsRequest request) => _proxy.Request<SslCertResponse>(request);
    }
}
