using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateDomainRequest : APIRequest
    {
        public CreateDomainRequest() : base("createDomain") {}

        /// <summary>
        /// creates domain with this name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Domain UUID, required for adding domain from another Region
        /// </summary>
        public string Domainid {
            get { return GetParameterValue<string>(nameof(Domainid).ToLower()); }
            set { SetParameterValue(nameof(Domainid).ToLower(), value); }
        }

        /// <summary>
        /// Network domain for networks in the domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// assigns new domain a parent domain by domain ID of the parent.  If no parent domain is specied, the ROOT domain is assumed.
        /// </summary>
        public Guid? ParentDomainId {
            get { return GetParameterValue<Guid?>(nameof(ParentDomainId).ToLower()); }
            set { SetParameterValue(nameof(ParentDomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainResponse CreateDomain(CreateDomainRequest request);
        Task<DomainResponse> CreateDomainAsync(CreateDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainResponse CreateDomain(CreateDomainRequest request) => Proxy.Request<DomainResponse>(request);
        public Task<DomainResponse> CreateDomainAsync(CreateDomainRequest request) => Proxy.RequestAsync<DomainResponse>(request);
    }
}
