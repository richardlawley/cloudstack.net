using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SamlSloRequest : APIRequest
    {
        public SamlSloRequest() : base("samlSlo") {}

    }
    /// <summary>
    /// SAML Global Log Out API
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LogoutCmdResponse SamlSlo(SamlSloRequest request);
        Task<LogoutCmdResponse> SamlSloAsync(SamlSloRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LogoutCmdResponse SamlSlo(SamlSloRequest request) => Proxy.Request<LogoutCmdResponse>(request);
        public Task<LogoutCmdResponse> SamlSloAsync(SamlSloRequest request) => Proxy.RequestAsync<LogoutCmdResponse>(request);
    }
}
