using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaUpdateRequest : APIRequest
    {
        public QuotaUpdateRequest() : base("quotaUpdate") {}

    }
    /// <summary>
    /// Update quota calculations, alerts and statements
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaUpdateResponse QuotaUpdate(QuotaUpdateRequest request);
        Task<QuotaUpdateResponse> QuotaUpdateAsync(QuotaUpdateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaUpdateResponse QuotaUpdate(QuotaUpdateRequest request) => _proxy.Request<QuotaUpdateResponse>(request);
        public Task<QuotaUpdateResponse> QuotaUpdateAsync(QuotaUpdateRequest request) => _proxy.RequestAsync<QuotaUpdateResponse>(request);
    }
}
