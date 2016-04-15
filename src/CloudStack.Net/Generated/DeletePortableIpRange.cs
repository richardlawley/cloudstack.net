using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePortableIpRangeRequest : APIRequest
    {
        public DeletePortableIpRangeRequest() : base("deletePortableIpRange") {}

        /// <summary>
        /// Id of the portable ip range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// deletes a range of portable public IP's associated with a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePortableIpRange(DeletePortableIpRangeRequest request);
        Task<AsyncJobResponse> DeletePortableIpRangeAsync(DeletePortableIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePortableIpRange(DeletePortableIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeletePortableIpRangeAsync(DeletePortableIpRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
