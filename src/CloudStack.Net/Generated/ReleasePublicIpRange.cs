using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleasePublicIpRangeRequest : APIRequest
    {
        public ReleasePublicIpRangeRequest() : base("releasePublicIpRange") {}

        /// <summary>
        /// the id of the Public IP range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Releases a Public IP range back to the system pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleasePublicIpRange(ReleasePublicIpRangeRequest request);
        Task<SuccessResponse> ReleasePublicIpRangeAsync(ReleasePublicIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleasePublicIpRange(ReleasePublicIpRangeRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ReleasePublicIpRangeAsync(ReleasePublicIpRangeRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
