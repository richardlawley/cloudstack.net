using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// remove vpn user from the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes vpn user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveVpnUser(RemoveVpnUserRequest request);
        Task<AsyncJobResponse> RemoveVpnUserAsync(RemoveVpnUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveVpnUser(RemoveVpnUserRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveVpnUserAsync(RemoveVpnUserRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
