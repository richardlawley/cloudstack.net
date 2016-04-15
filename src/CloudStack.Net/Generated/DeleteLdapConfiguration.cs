using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLdapConfigurationRequest : APIRequest
    {
        public DeleteLdapConfigurationRequest() : base("deleteLdapConfiguration") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

    }
    /// <summary>
    /// Remove an Ldap Configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request);
        Task<LdapConfigurationResponse> DeleteLdapConfigurationAsync(DeleteLdapConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request) => _proxy.Request<LdapConfigurationResponse>(request);
        public Task<LdapConfigurationResponse> DeleteLdapConfigurationAsync(DeleteLdapConfigurationRequest request) => _proxy.RequestAsync<LdapConfigurationResponse>(request);
    }
}
