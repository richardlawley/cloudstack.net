using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaEnabledResponse QuotaIsEnabled(QuotaIsEnabledRequest request) => _proxy.Request<QuotaEnabledResponse>(request);
    }
}
