using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid UserId {
            get { return (Guid) Parameters[nameof(UserId).ToLower()]; }
            set { Parameters[nameof(UserId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists and switches to other SAML accounts owned by the SAML user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ListAndSwitchSamlAccount(ListAndSwitchSamlAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ListAndSwitchSamlAccount(ListAndSwitchSamlAccountRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
