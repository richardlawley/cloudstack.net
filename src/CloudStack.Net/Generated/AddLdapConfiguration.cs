using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddLdapConfigurationRequest : APIRequest
    {
        public AddLdapConfigurationRequest() : base("addLdapConfiguration") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// Port
        /// </summary>
        public int Port {
            get { return (int) Parameters[nameof(Port).ToLower()]; }
            set { Parameters[nameof(Port).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Add a new Ldap Configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LdapConfigurationResponse AddLdapConfiguration(AddLdapConfigurationRequest request);
        Task<LdapConfigurationResponse> AddLdapConfigurationAsync(AddLdapConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LdapConfigurationResponse AddLdapConfiguration(AddLdapConfigurationRequest request) => _proxy.Request<LdapConfigurationResponse>(request);
        public Task<LdapConfigurationResponse> AddLdapConfigurationAsync(AddLdapConfigurationRequest request) => _proxy.RequestAsync<LdapConfigurationResponse>(request);
    }
}
