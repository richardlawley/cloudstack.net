using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Domain UUID, required for adding domain from another Region
        /// </summary>
        public string Domainid {
            get { return (string) Parameters[nameof(Domainid).ToLower()]; }
            set { Parameters[nameof(Domainid).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain for networks in the domain
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

        /// <summary>
        /// assigns new domain a parent domain by domain ID of the parent.  If no parent domain is specied, the ROOT domain is assumed.
        /// </summary>
        public Guid ParentDomainId {
            get { return (Guid) Parameters[nameof(ParentDomainId).ToLower()]; }
            set { Parameters[nameof(ParentDomainId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainResponse CreateDomain(CreateDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainResponse CreateDomain(CreateDomainRequest request) => _proxy.Request<DomainResponse>(request);
    }
}
