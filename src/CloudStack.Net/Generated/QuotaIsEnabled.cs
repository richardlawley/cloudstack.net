using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaIsEnabledRequest : APIRequest
    {
        public QuotaIsEnabledRequest() : base("quotaIsEnabled") {}

    }
    /// <summary>
    /// Return true if the plugin is enabled
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaEnabledResponse QuotaIsEnabled(QuotaIsEnabledRequest request);
        Task<QuotaEnabledResponse> QuotaIsEnabledAsync(QuotaIsEnabledRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaEnabledResponse QuotaIsEnabled(QuotaIsEnabledRequest request) => Proxy.Request<QuotaEnabledResponse>(request);
        public Task<QuotaEnabledResponse> QuotaIsEnabledAsync(QuotaIsEnabledRequest request) => Proxy.RequestAsync<QuotaEnabledResponse>(request);
    }
}
