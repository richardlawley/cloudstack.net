using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveGuestOsMappingRequest : APIRequest
    {
        public RemoveGuestOsMappingRequest() : base("removeGuestOsMapping") {}

        /// <summary>
        /// ID of the guest OS mapping
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes a Guest OS Mapping.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request);
        Task<AsyncJobResponse> RemoveGuestOsMappingAsync(RemoveGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveGuestOsMappingAsync(RemoveGuestOsMappingRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
