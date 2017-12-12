using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveGuestOsRequest : APIRequest
    {
        public RemoveGuestOsRequest() : base("removeGuestOs") {}

        /// <summary>
        /// ID of the guest OS
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a Guest OS from listing.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveGuestOs(RemoveGuestOsRequest request);
        Task<AsyncJobResponse> RemoveGuestOsAsync(RemoveGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveGuestOs(RemoveGuestOsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveGuestOsAsync(RemoveGuestOsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
