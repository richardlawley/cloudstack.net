using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(OsCategoryId).ToLower()); }
            set { SetParameterValue(nameof(OsCategoryId).ToLower(), value); }
        }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName {
            get { return GetParameterValue<string>(nameof(OsDisplayName).ToLower()); }
            set { SetParameterValue(nameof(OsDisplayName).ToLower(), value); }
        }

        /// <summary>
        /// Optional name for Guest OS
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Add a new guest OS type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddGuestOs(AddGuestOsRequest request);
        Task<AsyncJobResponse> AddGuestOsAsync(AddGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddGuestOs(AddGuestOsRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGuestOsAsync(AddGuestOsRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
