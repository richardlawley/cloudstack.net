using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapConfigurationsRequest : APIListRequest
    {
        public ListLdapConfigurationsRequest() : base("listLdapConfigurations") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// Port
        /// </summary>
        public int? Port {
            get { return (int?) Parameters[nameof(Port).ToLower()]; }
            set { Parameters[nameof(Port).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all LDAP configurations
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request);
        Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAsync(ListLdapConfigurationsRequest request);
        ListResponse<LdapConfigurationResponse> ListLdapConfigurationsAllPages(ListLdapConfigurationsRequest request);
        Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAllPagesAsync(ListLdapConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request) => _proxy.Request<ListResponse<LdapConfigurationResponse>>(request);
        public Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAsync(ListLdapConfigurationsRequest request) => _proxy.RequestAsync<ListResponse<LdapConfigurationResponse>>(request);
        public ListResponse<LdapConfigurationResponse> ListLdapConfigurationsAllPages(ListLdapConfigurationsRequest request) => _proxy.RequestAllPages<LdapConfigurationResponse>(request);
        public Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAllPagesAsync(ListLdapConfigurationsRequest request) => _proxy.RequestAllPagesAsync<LdapConfigurationResponse>(request);
    }
}
