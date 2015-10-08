using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapConfigurationsRequest : APIRequest
    {
        public ListLdapConfigurationsRequest() : base("listLdapConfigurations") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        public int? Port { get; set; }

    }
    /// <summary>
    /// Lists all LDAP configurations
    /// </summary>
    /// <summary>
    /// Lists all LDAP configurations
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request) => _proxy.Request<ListResponse<LdapConfigurationResponse>>(request);
    }
}
