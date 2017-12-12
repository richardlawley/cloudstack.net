using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSamlAuthorizationRequest : APIListRequest
    {
        public ListSamlAuthorizationRequest() : base("listSamlAuthorization") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid? UserId {
            get { return GetParameterValue<Guid?>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists authorized users who can used SAML SSO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SamlAuthorizationResponse> ListSamlAuthorization(ListSamlAuthorizationRequest request);
        Task<ListResponse<SamlAuthorizationResponse>> ListSamlAuthorizationAsync(ListSamlAuthorizationRequest request);
        ListResponse<SamlAuthorizationResponse> ListSamlAuthorizationAllPages(ListSamlAuthorizationRequest request);
        Task<ListResponse<SamlAuthorizationResponse>> ListSamlAuthorizationAllPagesAsync(ListSamlAuthorizationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SamlAuthorizationResponse> ListSamlAuthorization(ListSamlAuthorizationRequest request) => Proxy.Request<ListResponse<SamlAuthorizationResponse>>(request);
        public Task<ListResponse<SamlAuthorizationResponse>> ListSamlAuthorizationAsync(ListSamlAuthorizationRequest request) => Proxy.RequestAsync<ListResponse<SamlAuthorizationResponse>>(request);
        public ListResponse<SamlAuthorizationResponse> ListSamlAuthorizationAllPages(ListSamlAuthorizationRequest request) => Proxy.RequestAllPages<SamlAuthorizationResponse>(request);
        public Task<ListResponse<SamlAuthorizationResponse>> ListSamlAuthorizationAllPagesAsync(ListSamlAuthorizationRequest request) => Proxy.RequestAllPagesAsync<SamlAuthorizationResponse>(request);
    }
}
