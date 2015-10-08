using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// <summary>
    /// SAML Global Log Out API
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LogoutCmdResponse SamlSlo(SamlSloRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LogoutCmdResponse SamlSlo(SamlSloRequest request) => _proxy.Request<LogoutCmdResponse>(request);
    }
}
