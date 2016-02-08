using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDomainRequest : APIRequest
    {
        public UpdateDomainRequest() : base("updateDomain") {}

        /// <summary>
        /// ID of domain to update
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// updates domain with this name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain for the domain's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a domain with a new name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainResponse UpdateDomain(UpdateDomainRequest request);
        Task<DomainResponse> UpdateDomainAsync(UpdateDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainResponse UpdateDomain(UpdateDomainRequest request) => _proxy.Request<DomainResponse>(request);
        public Task<DomainResponse> UpdateDomainAsync(UpdateDomainRequest request) => _proxy.RequestAsync<DomainResponse>(request);
    }
}
