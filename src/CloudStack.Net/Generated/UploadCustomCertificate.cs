using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Certificate).ToLower()]; }
            set { Parameters[nameof(Certificate).ToLower()] = value; }
        }

        /// <summary>
        /// DNS domain suffix that the certificate is granted for.
        /// </summary>
        public string DomainSuffix {
            get { return (string) Parameters[nameof(DomainSuffix).ToLower()]; }
            set { Parameters[nameof(DomainSuffix).ToLower()] = value; }
        }

        /// <summary>
        /// An integer providing the location in a chain that the certificate will hold. Usually, this can be left empty. When creating a chain, the top level certificate should have an ID of 1, with each step in the chain incrementing by one. Example, CA with id = 1, Intermediate CA with id = 2, Site certificate with ID = 3
        /// </summary>
        public int? Id {
            get { return (int?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// A name / alias for the certificate.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// The private key for the attached certificate.
        /// </summary>
        public string PrivateKey {
            get { return (string) Parameters[nameof(PrivateKey).ToLower()]; }
            set { Parameters[nameof(PrivateKey).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Uploads a custom certificate for the console proxy VMs to use for SSL. Can be used to upload a single certificate signed by a known CA. Can also be used, through multiple calls, to upload a chain of certificates from CA to the custom certificate itself.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UploadCustomCertificate(UploadCustomCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UploadCustomCertificate(UploadCustomCertificateRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
