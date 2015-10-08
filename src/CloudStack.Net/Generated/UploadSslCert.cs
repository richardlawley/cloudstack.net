using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadSslCertRequest : APIRequest
    {
        public UploadSslCertRequest() : base("uploadSslCert") {}

        /// <summary>
        /// SSL certificate
        /// </summary>
        public string Cert { get; set; }

        /// <summary>
        /// Private key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// account that will own the SSL certificate
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Certificate chain of trust
        /// </summary>
        public string Chain { get; set; }

        /// <summary>
        /// domain ID of the account owning the SSL certificate
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Password for the private key
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// an optional project for the SSL certificate
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Upload a certificate to CloudStack
    /// </summary>
    /// <summary>
    /// Upload a certificate to CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SslCertResponse UploadSslCert(UploadSslCertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SslCertResponse UploadSslCert(UploadSslCertRequest request) => _proxy.Request<SslCertResponse>(request);
    }
}
