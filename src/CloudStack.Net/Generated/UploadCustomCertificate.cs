using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadCustomCertificateRequest : APIRequest
    {
        public UploadCustomCertificateRequest() : base("uploadCustomCertificate") {}

        /// <summary>
        /// The certificate to be uploaded.
        /// </summary>
        public string Certificate {
            get { return GetParameterValue<string>(nameof(Certificate).ToLower()); }
            set { SetParameterValue(nameof(Certificate).ToLower(), value); }
        }

        /// <summary>
        /// DNS domain suffix that the certificate is granted for.
        /// </summary>
        public string DomainSuffix {
            get { return GetParameterValue<string>(nameof(DomainSuffix).ToLower()); }
            set { SetParameterValue(nameof(DomainSuffix).ToLower(), value); }
        }

        /// <summary>
        /// An integer providing the location in a chain that the certificate will hold. Usually, this can be left empty. When creating a chain, the top level certificate should have an ID of 1, with each step in the chain incrementing by one. Example, CA with id = 1, Intermediate CA with id = 2, Site certificate with ID = 3
        /// </summary>
        public int? Id {
            get { return GetParameterValue<int?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// A name / alias for the certificate.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The private key for the attached certificate.
        /// </summary>
        public string PrivateKey {
            get { return GetParameterValue<string>(nameof(PrivateKey).ToLower()); }
            set { SetParameterValue(nameof(PrivateKey).ToLower(), value); }
        }

    }
    /// <summary>
    /// Uploads a custom certificate for the console proxy VMs to use for SSL. Can be used to upload a single certificate signed by a known CA. Can also be used, through multiple calls, to upload a chain of certificates from CA to the custom certificate itself.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UploadCustomCertificate(UploadCustomCertificateRequest request);
        Task<AsyncJobResponse> UploadCustomCertificateAsync(UploadCustomCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UploadCustomCertificate(UploadCustomCertificateRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UploadCustomCertificateAsync(UploadCustomCertificateRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
