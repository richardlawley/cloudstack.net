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
        public string Certificate { get; set; }

        /// <summary>
        /// DNS domain suffix that the certificate is granted for.
        /// </summary>
        public string DomainSuffix { get; set; }

        /// <summary>
        /// An integer providing the location in a chain that the certificate will hold. Usually, this can be left empty. When creating a chain, the top level certificate should have an ID of 1, with each step in the chain incrementing by one. Example, CA with id = 1, Intermediate CA with id = 2, Site certificate with ID = 3
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// A name / alias for the certificate.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// The private key for the attached certificate.
        /// </summary>
        public string PrivateKey { get; set; }

    }
    /// <summary>
    /// Uploads a custom certificate for the console proxy VMs to use for SSL. Can be used to upload a single certificate signed by a known CA. Can also be used, through multiple calls, to upload a chain of certificates from CA to the custom certificate itself.
    /// </summary>
    /// <summary>
    /// Uploads a custom certificate for the console proxy VMs to use for SSL. Can be used to upload a single certificate signed by a known CA. Can also be used, through multiple calls, to upload a chain of certificates from CA to the custom certificate itself.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CustomCertificateResponse UploadCustomCertificate(UploadCustomCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CustomCertificateResponse UploadCustomCertificate(UploadCustomCertificateRequest request) => _proxy.Request<CustomCertificateResponse>(request);
    }
}
