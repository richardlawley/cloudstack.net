using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Certificate).ToLower()); }
            set { SetParameterValue(nameof(Certificate).ToLower(), value); }
        }

        /// <summary>
        /// Private key
        /// </summary>
        public string Privatekey {
            get { return GetParameterValue<string>(nameof(Privatekey).ToLower()); }
            set { SetParameterValue(nameof(Privatekey).ToLower(), value); }
        }

        /// <summary>
        /// account that will own the SSL certificate
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Certificate chain of trust
        /// </summary>
        public string Certchain {
            get { return GetParameterValue<string>(nameof(Certchain).ToLower()); }
            set { SetParameterValue(nameof(Certchain).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning the SSL certificate
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Password for the private key
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the SSL certificate
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Upload a certificate to CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SslCertResponse UploadSslCert(UploadSslCertRequest request);
        Task<SslCertResponse> UploadSslCertAsync(UploadSslCertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SslCertResponse UploadSslCert(UploadSslCertRequest request) => _proxy.Request<SslCertResponse>(request);
        public Task<SslCertResponse> UploadSslCertAsync(UploadSslCertRequest request) => _proxy.RequestAsync<SslCertResponse>(request);
    }
}
