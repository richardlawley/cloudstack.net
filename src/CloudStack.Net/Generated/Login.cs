using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LoginRequest : APIRequest
    {
        public LoginRequest() : base("login") {}

        /// <summary>
        /// Hashed password (Default is MD5). If you wish to use any other hashing algorithm, you would need to write a custom authentication adapter See Docs section.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Path of the domain that the user belongs to. Example: domain=/com/cloud/internal. If no domain is passed in, the ROOT (/) domain is assumed.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// The id of the domain that the user belongs to. If both domain and domainId are passed in, "domainId" parameter takes precendence
        /// </summary>
        public long? DomainId { get; set; }

    }
    /// <summary>
    /// Logs a user into the CloudStack. A successful login attempt will generate a JSESSIONID cookie value that can be passed in subsequent Query command calls until the "logout" command has been issued or the session has expired.
    /// </summary>
    /// <summary>
    /// Logs a user into the CloudStack. A successful login attempt will generate a JSESSIONID cookie value that can be passed in subsequent Query command calls until the "logout" command has been issued or the session has expired.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoginCmdResponse Login(LoginRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoginCmdResponse Login(LoginRequest request) => _proxy.Request<LoginCmdResponse>(request);
    }
}
