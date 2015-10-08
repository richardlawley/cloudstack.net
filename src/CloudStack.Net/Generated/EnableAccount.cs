using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableAccountRequest : APIRequest
    {
        public EnableAccountRequest() : base("enableAccount") {}

        /// <summary>
        /// Enables specified account.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Enables specified account in this domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Enables an account
    /// </summary>
    /// <summary>
    /// Enables an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse EnableAccount(EnableAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse EnableAccount(EnableAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
