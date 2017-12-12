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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// updates domain with this name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Network domain for the domain's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
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
        public DomainResponse UpdateDomain(UpdateDomainRequest request) => Proxy.Request<DomainResponse>(request);
        public Task<DomainResponse> UpdateDomainAsync(UpdateDomainRequest request) => Proxy.RequestAsync<DomainResponse>(request);
    }
}
