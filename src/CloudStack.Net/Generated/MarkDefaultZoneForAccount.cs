using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MarkDefaultZoneForAccountRequest : APIRequest
    {
        public MarkDefaultZoneForAccountRequest() : base("markDefaultZoneForAccount") {}

        /// <summary>
        /// Name of the account that is to be marked.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Marks the account that belongs to the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// The Zone ID with which the account is to be marked.
        /// </summary>
        public Guid DefaultZoneId { get; set; }

    }
    /// <summary>
    /// Marks a default zone for this account
    /// </summary>
    /// <summary>
    /// Marks a default zone for this account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse MarkDefaultZoneForAccount(MarkDefaultZoneForAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse MarkDefaultZoneForAccount(MarkDefaultZoneForAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
