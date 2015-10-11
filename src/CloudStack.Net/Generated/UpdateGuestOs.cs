using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGuestOsRequest : APIRequest
    {
        public UpdateGuestOsRequest() : base("updateGuestOs") {}

        /// <summary>
        /// UUID of the Guest OS
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName {
            get { return (string) Parameters[nameof(OsDisplayName).ToLower()]; }
            set { Parameters[nameof(OsDisplayName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates the information about Guest OS
    /// </summary>
    /// <summary>
    /// Updates the information about Guest OS
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestOSResponse UpdateGuestOs(UpdateGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestOSResponse UpdateGuestOs(UpdateGuestOsRequest request) => _proxy.Request<GuestOSResponse>(request);
    }
}
