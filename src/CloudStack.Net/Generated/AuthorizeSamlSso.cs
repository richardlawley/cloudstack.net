using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AuthorizeSamlSsoRequest : APIRequest
    {
        public AuthorizeSamlSsoRequest() : base("authorizeSamlSso") {}

        /// <summary>
        /// If true, authorizes user to be able to use SAML for Single Sign. If False, disable user to user SAML SSO.
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The Identity Provider ID the user is allowed to get single signed on from
        /// </summary>
        public string EntityId { get; set; }

    }
    /// <summary>
    /// Allow or disallow a user to use SAML SSO
    /// </summary>
    /// <summary>
    /// Allow or disallow a user to use SAML SSO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AuthorizeSamlSso(AuthorizeSamlSsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AuthorizeSamlSso(AuthorizeSamlSsoRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
