using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SamlSsoRequest : APIRequest
    {
        public SamlSsoRequest() : base("samlSso") {}

        /// <summary>
        /// Identity Provider Entity ID
        /// </summary>
        public string IdpId {
            get { return (string) Parameters[nameof(IdpId).ToLower()]; }
            set { Parameters[nameof(IdpId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// SP initiated SAML Single Sign On
    /// </summary>
    /// <summary>
    /// SP initiated SAML Single Sign On
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoginCmdResponse SamlSso(SamlSsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoginCmdResponse SamlSso(SamlSsoRequest request) => _proxy.Request<LoginCmdResponse>(request);
    }
}
