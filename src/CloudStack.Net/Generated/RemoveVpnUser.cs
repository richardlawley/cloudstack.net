using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveVpnUserRequest : APIRequest
    {
        public RemoveVpnUserRequest() : base("removeVpnUser") {}

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
        /// remove vpn user from the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes vpn user
    /// </summary>
    /// <summary>
    /// Removes vpn user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveVpnUser(RemoveVpnUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveVpnUser(RemoveVpnUserRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
