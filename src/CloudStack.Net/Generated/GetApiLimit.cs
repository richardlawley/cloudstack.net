using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetApiLimitRequest : APIRequest
    {
        public GetApiLimitRequest() : base("getApiLimit") {}

    }
    /// <summary>
    /// Get API limit count for the caller
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiLimitResponse GetApiLimit(GetApiLimitRequest request);
        Task<ApiLimitResponse> GetApiLimitAsync(GetApiLimitRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiLimitResponse GetApiLimit(GetApiLimitRequest request) => _proxy.Request<ApiLimitResponse>(request);
        public Task<ApiLimitResponse> GetApiLimitAsync(GetApiLimitRequest request) => _proxy.RequestAsync<ApiLimitResponse>(request);
    }
}
