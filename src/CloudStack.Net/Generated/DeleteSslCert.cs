using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSslCertRequest : APIRequest
    {
        public DeleteSslCertRequest() : base("deleteSslCert") {}

        /// <summary>
        /// Id of SSL certificate
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Delete a certificate to CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSslCert(DeleteSslCertRequest request);
        Task<SuccessResponse> DeleteSslCertAsync(DeleteSslCertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSslCert(DeleteSslCertRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteSslCertAsync(DeleteSslCertRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
