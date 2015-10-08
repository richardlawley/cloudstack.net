using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddLdapConfigurationRequest : APIRequest
    {
        public AddLdapConfigurationRequest() : base("addLdapConfiguration") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        public int Port { get; set; }

    }
    /// <summary>
    /// Add a new Ldap Configuration
    /// </summary>
    /// <summary>
    /// Add a new Ldap Configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LdapConfigurationResponse AddLdapConfiguration(AddLdapConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LdapConfigurationResponse AddLdapConfiguration(AddLdapConfigurationRequest request) => _proxy.Request<LdapConfigurationResponse>(request);
    }
}
