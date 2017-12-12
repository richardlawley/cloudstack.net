using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteDomainRequest : APIRequest
    {
        public DeleteDomainRequest() : base("deleteDomain") {}

        /// <summary>
        /// ID of domain to delete
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// true if all domain resources (child domains, accounts) have to be cleaned up, false otherwise
        /// </summary>
        public bool? Cleanup {
            get { return GetParameterValue<bool?>(nameof(Cleanup).ToLower()); }
            set { SetParameterValue(nameof(Cleanup).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteDomain(DeleteDomainRequest request);
        Task<AsyncJobResponse> DeleteDomainAsync(DeleteDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteDomain(DeleteDomainRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteDomainAsync(DeleteDomainRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
