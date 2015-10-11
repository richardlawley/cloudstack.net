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
        public bool Lock {
            get { return (bool) Parameters[nameof(Lock).ToLower()]; }
            set { Parameters[nameof(Lock).ToLower()] = value; }
        }

        /// <summary>
        /// Disables specified account.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Disables specified account in this domain.
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

    }
    /// <summary>
    /// Disables an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableAccount(DisableAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableAccount(DisableAccountRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
