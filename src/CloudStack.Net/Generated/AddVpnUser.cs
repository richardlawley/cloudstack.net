using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddVpnUserRequest : APIRequest
    {
        public AddVpnUserRequest() : base("addVpnUser") {}

        /// <summary>
        /// password for the username
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// username for the vpn user
        /// </summary>
        public string UserName {
            get { return (string) Parameters[nameof(UserName).ToLower()]; }
            set { Parameters[nameof(UserName).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for the vpn user. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the vpn user. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// add vpn user to the specific project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds vpn users
    /// </summary>
    /// <summary>
    /// Adds vpn users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddVpnUser(AddVpnUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddVpnUser(AddVpnUserRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
