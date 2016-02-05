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
        public Guid AccountId {
            get { return (Guid) Parameters[nameof(AccountId).ToLower()]; }
            set { Parameters[nameof(AccountId).ToLower()] = value; }
        }

        /// <summary>
        /// ID of SSL certificate
        /// </summary>
        public Guid CertId {
            get { return (Guid) Parameters[nameof(CertId).ToLower()]; }
            set { Parameters[nameof(CertId).ToLower()] = value; }
        }

        /// <summary>
        /// Load balancer rule ID
        /// </summary>
        public Guid Lbruleid {
            get { return (Guid) Parameters[nameof(Lbruleid).ToLower()]; }
            set { Parameters[nameof(Lbruleid).ToLower()] = value; }
        }

        /// <summary>
        /// Project that owns the SSL certificate
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
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
