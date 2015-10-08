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
        public string DomainName { get; set; }

        /// <summary>
        /// Domain UUID, required for adding domain from another Region
        /// </summary>
        public string DomainUUID { get; set; }

        /// <summary>
        /// Network domain for networks in the domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// assigns new domain a parent domain by domain ID of the parent.  If no parent domain is specied, the ROOT domain is assumed.
        /// </summary>
        public Guid ParentDomainId { get; set; }

    }
    /// <summary>
    /// Creates a domain
    /// </summary>
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
