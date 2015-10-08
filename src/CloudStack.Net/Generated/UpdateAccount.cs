using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAccountRequest : APIRequest
    {
        public UpdateAccountRequest() : base("updateAccount") {}

        /// <summary>
        /// new name for the account
        /// </summary>
        public string NewName { get; set; }

        /// <summary>
        /// the current account name
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the ID of the domain where the account exists
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Network domain for the account's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain { get; set; }

    }
    /// <summary>
    /// Updates account information for the authenticated user
    /// </summary>
    /// <summary>
    /// Updates account information for the authenticated user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse UpdateAccount(UpdateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse UpdateAccount(UpdateAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
