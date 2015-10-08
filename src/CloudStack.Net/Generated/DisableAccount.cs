using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableAccountRequest : APIRequest
    {
        public DisableAccountRequest() : base("disableAccount") {}

        /// <summary>
        /// If true, only lock the account; else disable the account
        /// </summary>
        public bool LockRequested { get; set; }

        /// <summary>
        /// Disables specified account.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Disables specified account in this domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Disables an account
    /// </summary>
    /// <summary>
    /// Disables an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse DisableAccount(DisableAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse DisableAccount(DisableAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
