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
        public string NewName {
            get { return (string) Parameters[nameof(NewName).ToLower()]; }
            set { Parameters[nameof(NewName).ToLower()] = value; }
        }

        /// <summary>
        /// the current account name
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IDictionary<string, string> Accountdetails {
            get { return (IDictionary<string, string>) Parameters[nameof(Accountdetails).ToLower()]; }
            set { Parameters[nameof(Accountdetails).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain where the account exists
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain for the account's networks; empty string will update domainName with NULL value
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

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
