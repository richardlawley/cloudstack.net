using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDomainRequest : APIRequest
    {
        public UpdateDomainRequest() : base("updateDomain") {}

        /// <summary>
        /// ID of domain to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// updates domain with this name
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Network domain for the domain's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain { get; set; }

    }
    /// <summary>
    /// Updates a domain with a new name
    /// </summary>
    /// <summary>
    /// Updates a domain with a new name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainResponse UpdateDomain(UpdateDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainResponse UpdateDomain(UpdateDomainRequest request) => _proxy.Request<DomainResponse>(request);
    }
}
