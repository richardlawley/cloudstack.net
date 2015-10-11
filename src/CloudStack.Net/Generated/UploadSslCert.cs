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
        public string Certificate {
            get { return (string) Parameters[nameof(Certificate).ToLower()]; }
            set { Parameters[nameof(Certificate).ToLower()] = value; }
        }

        /// <summary>
        /// Private key
        /// </summary>
        public string Privatekey {
            get { return (string) Parameters[nameof(Privatekey).ToLower()]; }
            set { Parameters[nameof(Privatekey).ToLower()] = value; }
        }

        /// <summary>
        /// account who will own the ssl cert
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Certificate chain of trust
        /// </summary>
        public string Certchain {
            get { return (string) Parameters[nameof(Certchain).ToLower()]; }
            set { Parameters[nameof(Certchain).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning the ssl cert
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Password for the private key
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// an optional project for the ssl cert
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Upload a certificate to cloudstack
    /// </summary>
    /// <summary>
    /// Upload a certificate to cloudstack
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
