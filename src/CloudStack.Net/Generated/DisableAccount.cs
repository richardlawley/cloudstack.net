using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableAccountRequest : APIRequest
    {
        public DisableAccountRequest() : base("disableAccount") {}

        /// <summary>
        /// If true, only lock the account; else disable the account
        /// </summary>
        public bool Lock {
            get { return GetParameterValue<bool>(nameof(Lock).ToLower()); }
            set { SetParameterValue(nameof(Lock).ToLower(), value); }
        }

        /// <summary>
        /// Disables specified account.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Disables specified account in this domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableAccount(DisableAccountRequest request);
        Task<AsyncJobResponse> DisableAccountAsync(DisableAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableAccount(DisableAccountRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableAccountAsync(DisableAccountRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
