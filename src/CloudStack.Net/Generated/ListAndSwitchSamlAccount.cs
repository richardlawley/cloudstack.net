using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAndSwitchSamlAccountRequest : APIRequest
    {
        public ListAndSwitchSamlAccountRequest() : base("listAndSwitchSamlAccount") {}

        /// <summary>
        /// Domain uuid
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid UserId {
            get { return GetParameterValue<Guid>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists and switches to other SAML accounts owned by the SAML user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ListAndSwitchSamlAccount(ListAndSwitchSamlAccountRequest request);
        Task<SuccessResponse> ListAndSwitchSamlAccountAsync(ListAndSwitchSamlAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ListAndSwitchSamlAccount(ListAndSwitchSamlAccountRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ListAndSwitchSamlAccountAsync(ListAndSwitchSamlAccountRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
