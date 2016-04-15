using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// username for the vpn user
        /// </summary>
        public string UserName {
            get { return GetParameterValue<string>(nameof(UserName).ToLower()); }
            set { SetParameterValue(nameof(UserName).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the vpn user. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the vpn user. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// add vpn user to the specific project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds vpn users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddVpnUser(AddVpnUserRequest request);
        Task<AsyncJobResponse> AddVpnUserAsync(AddVpnUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddVpnUser(AddVpnUserRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddVpnUserAsync(AddVpnUserRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
