using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// true if all domain resources (child domains, accounts) have to be cleaned up, false otherwise
        /// </summary>
        public bool? Cleanup {
            get { return (bool?) Parameters[nameof(Cleanup).ToLower()]; }
            set { Parameters[nameof(Cleanup).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a specified domain
    /// </summary>
    /// <summary>
    /// Deletes a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteDomain(DeleteDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteDomain(DeleteDomainRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
