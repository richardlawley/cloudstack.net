using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes a Guest OS from listing.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveGuestOs(RemoveGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveGuestOs(RemoveGuestOsRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
