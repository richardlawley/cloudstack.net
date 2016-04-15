using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName {
            get { return GetParameterValue<string>(nameof(OsDisplayName).ToLower()); }
            set { SetParameterValue(nameof(OsDisplayName).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates the information about Guest OS
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGuestOs(UpdateGuestOsRequest request);
        Task<AsyncJobResponse> UpdateGuestOsAsync(UpdateGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGuestOs(UpdateGuestOsRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateGuestOsAsync(UpdateGuestOsRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
