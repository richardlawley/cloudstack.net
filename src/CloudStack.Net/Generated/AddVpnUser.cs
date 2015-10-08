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
        public string Password { get; set; }

        /// <summary>
        /// username for the vpn user
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// an optional account for the vpn user. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional domainId for the vpn user. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// add vpn user to the specific project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Adds vpn users
    /// </summary>
    /// <summary>
    /// Adds vpn users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpnUsersResponse AddVpnUser(AddVpnUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpnUsersResponse AddVpnUser(AddVpnUserRequest request) => _proxy.Request<VpnUsersResponse>(request);
    }
}
