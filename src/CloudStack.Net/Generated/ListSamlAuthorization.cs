using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSamlAuthorizationRequest : APIRequest
    {
        public ListSamlAuthorizationRequest() : base("listSamlAuthorization") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid UserId { get; set; }

    }
    /// <summary>
    /// Lists authorized users who can used SAML SSO
    /// </summary>
    /// <summary>
    /// Lists authorized users who can used SAML SSO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SamlAuthorizationResponse> ListSamlAuthorization(ListSamlAuthorizationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SamlAuthorizationResponse> ListSamlAuthorization(ListSamlAuthorizationRequest request) => _proxy.Request<ListResponse<SamlAuthorizationResponse>>(request);
    }
}
