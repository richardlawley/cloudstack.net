using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAccountRequest : APIRequest
    {
        public UpdateAccountRequest() : base("updateAccount") {}

        /// <summary>
        /// new name for the account
        /// </summary>
        public string NewName {
            get { return GetParameterValue<string>(nameof(NewName).ToLower()); }
            set { SetParameterValue(nameof(NewName).ToLower(), value); }
        }

        /// <summary>
        /// the current account name
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IList<IDictionary<string, object>> Accountdetails {
            get { return GetList<IDictionary<string, object>>(nameof(Accountdetails).ToLower()); }
            set { SetParameterValue(nameof(Accountdetails).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain where the account exists
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

        /// <summary>
        /// Network domain for the account's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates account information for the authenticated user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse UpdateAccount(UpdateAccountRequest request);
        Task<AccountResponse> UpdateAccountAsync(UpdateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse UpdateAccount(UpdateAccountRequest request) => _proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> UpdateAccountAsync(UpdateAccountRequest request) => _proxy.RequestAsync<AccountResponse>(request);
    }
}
