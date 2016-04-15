using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AuthorizeSamlSsoRequest : APIRequest
    {
        public AuthorizeSamlSsoRequest() : base("authorizeSamlSso") {}

        /// <summary>
        /// If true, authorizes user to be able to use SAML for Single Sign. If False, disable user to user SAML SSO.
        /// </summary>
        public bool Enable {
            get { return GetParameterValue<bool>(nameof(Enable).ToLower()); }
            set { SetParameterValue(nameof(Enable).ToLower(), value); }
        }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid Userid {
            get { return GetParameterValue<Guid>(nameof(Userid).ToLower()); }
            set { SetParameterValue(nameof(Userid).ToLower(), value); }
        }

        /// <summary>
        /// The Identity Provider ID the user is allowed to get single signed on from
        /// </summary>
        public string EntityId {
            get { return GetParameterValue<string>(nameof(EntityId).ToLower()); }
            set { SetParameterValue(nameof(EntityId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Allow or disallow a user to use SAML SSO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AuthorizeSamlSso(AuthorizeSamlSsoRequest request);
        Task<SuccessResponse> AuthorizeSamlSsoAsync(AuthorizeSamlSsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AuthorizeSamlSso(AuthorizeSamlSsoRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> AuthorizeSamlSsoAsync(AuthorizeSamlSsoRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
