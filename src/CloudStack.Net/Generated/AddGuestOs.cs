using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGuestOsRequest : APIRequest
    {
        public AddGuestOsRequest() : base("addGuestOs") {}

        /// <summary>
        /// ID of Guest OS category
        /// </summary>
        public Guid OsCategoryId { get; set; }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName { get; set; }

        /// <summary>
        /// Optional name for Guest OS
        /// </summary>
        public string OsName { get; set; }

    }
    /// <summary>
    /// Add a new guest OS type
    /// </summary>
    /// <summary>
    /// Add a new guest OS type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestOSResponse AddGuestOs(AddGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestOSResponse AddGuestOs(AddGuestOsRequest request) => _proxy.Request<GuestOSResponse>(request);
    }
}
