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
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Port
        /// </summary>
        public int? Port {
            get { return GetParameterValue<int?>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
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
