using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LogoutRequest : APIRequest
    {
        public LogoutRequest() : base("logout") {}

    }
    /// <summary>
    /// Logs out the user
    /// </summary>
    /// <summary>
    /// Logs out the user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LogoutCmdResponse Logout(LogoutRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LogoutCmdResponse Logout(LogoutRequest request) => _proxy.Request<LogoutCmdResponse>(request);
    }
}
