using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
    public partial interface ICloudStackAPIClient
    {
        LogoutCmdResponse Logout(LogoutRequest request);
        Task<LogoutCmdResponse> LogoutAsync(LogoutRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LogoutCmdResponse Logout(LogoutRequest request) => Proxy.Request<LogoutCmdResponse>(request);
        public Task<LogoutCmdResponse> LogoutAsync(LogoutRequest request) => Proxy.RequestAsync<LogoutCmdResponse>(request);
    }
}
