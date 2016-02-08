using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsageTypesRequest : APIRequest
    {
        public ListUsageTypesRequest() : base("listUsageTypes") {}

    }
    /// <summary>
    /// List Usage Types
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UsageTypeResponse ListUsageTypes(ListUsageTypesRequest request);
        Task<UsageTypeResponse> ListUsageTypesAsync(ListUsageTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UsageTypeResponse ListUsageTypes(ListUsageTypesRequest request) => _proxy.Request<UsageTypeResponse>(request);
        public Task<UsageTypeResponse> ListUsageTypesAsync(ListUsageTypesRequest request) => _proxy.RequestAsync<UsageTypeResponse>(request);
    }
}
