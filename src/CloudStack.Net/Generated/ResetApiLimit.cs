using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetApiLimitRequest : APIRequest
    {
        public ResetApiLimitRequest() : base("resetApiLimit") {}

        /// <summary>
        /// the ID of the acount whose limit to be reset
        /// </summary>
        public Guid Account {
            get { return GetParameterValue<Guid>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reset api count
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiLimitResponse ResetApiLimit(ResetApiLimitRequest request);
        Task<ApiLimitResponse> ResetApiLimitAsync(ResetApiLimitRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiLimitResponse ResetApiLimit(ResetApiLimitRequest request) => _proxy.Request<ApiLimitResponse>(request);
        public Task<ApiLimitResponse> ResetApiLimitAsync(ResetApiLimitRequest request) => _proxy.RequestAsync<ApiLimitResponse>(request);
    }
}
