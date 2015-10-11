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
        public Guid OsCategoryId {
            get { return (Guid) Parameters[nameof(OsCategoryId).ToLower()]; }
            set { Parameters[nameof(OsCategoryId).ToLower()] = value; }
        }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName {
            get { return (string) Parameters[nameof(OsDisplayName).ToLower()]; }
            set { Parameters[nameof(OsDisplayName).ToLower()] = value; }
        }

        /// <summary>
        /// Optional name for Guest OS
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Add a new guest OS type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddGuestOs(AddGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddGuestOs(AddGuestOsRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
