using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableAccountRequest : APIRequest
    {
        public EnableAccountRequest() : base("enableAccount") {}

        /// <summary>
        /// Enables specified account.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Enables specified account in this domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse EnableAccount(EnableAccountRequest request);
        Task<AccountResponse> EnableAccountAsync(EnableAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse EnableAccount(EnableAccountRequest request) => _proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> EnableAccountAsync(EnableAccountRequest request) => _proxy.RequestAsync<AccountResponse>(request);
    }
}
