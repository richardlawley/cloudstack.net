using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Remove an Ldap Configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request) => _proxy.Request<LdapConfigurationResponse>(request);
    }
}
