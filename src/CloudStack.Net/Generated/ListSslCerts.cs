using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSslCertsRequest : APIRequest
    {
        public ListSslCertsRequest() : base("listSslCerts") {}

        /// <summary>
        /// Account ID
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// ID of SSL certificate
        /// </summary>
        public Guid? CertId {
            get { return GetParameterValue<Guid?>(nameof(CertId).ToLower()); }
            set { SetParameterValue(nameof(CertId).ToLower(), value); }
        }

        /// <summary>
        /// Load balancer rule ID
        /// </summary>
        public Guid? Lbruleid {
            get { return GetParameterValue<Guid?>(nameof(Lbruleid).ToLower()); }
            set { SetParameterValue(nameof(Lbruleid).ToLower(), value); }
        }

        /// <summary>
        /// Project that owns the SSL certificate
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists SSL certificates
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SslCertResponse ListSslCerts(ListSslCertsRequest request);
        Task<SslCertResponse> ListSslCertsAsync(ListSslCertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SslCertResponse ListSslCerts(ListSslCertsRequest request) => Proxy.Request<SslCertResponse>(request);
        public Task<SslCertResponse> ListSslCertsAsync(ListSslCertsRequest request) => Proxy.RequestAsync<SslCertResponse>(request);
    }
}
