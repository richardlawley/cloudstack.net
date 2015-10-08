using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LockAccountRequest : APIRequest
    {
        public LockAccountRequest() : base("lockAccount") {}

        /// <summary>
        /// Locks the specified account.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Locks the specified account on this domain.
        /// </summary>
        public Guid DomainId { get; set; }

    }
    /// <summary>
    /// Locks an account
    /// </summary>
    /// <summary>
    /// Locks an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse LockAccount(LockAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse LockAccount(LockAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
