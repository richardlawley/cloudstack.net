using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LockAccountRequest : APIRequest
    {
        public LockAccountRequest() : base("lockAccount") {}

        /// <summary>
        /// Locks the specified account.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Locks the specified account on this domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// This deprecated function used to locks an account. Look for the API DisableAccount instead
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse LockAccount(LockAccountRequest request);
        Task<AccountResponse> LockAccountAsync(LockAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse LockAccount(LockAccountRequest request) => _proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> LockAccountAsync(LockAccountRequest request) => _proxy.RequestAsync<AccountResponse>(request);
    }
}
