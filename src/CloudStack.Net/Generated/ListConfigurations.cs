using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConfigurationsRequest : APIListRequest
    {
        public ListConfigurationsRequest() : base("listConfigurations") {}

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid AccountId {
            get { return (Guid) Parameters[nameof(AccountId).ToLower()]; }
            set { Parameters[nameof(AccountId).ToLower()] = value; }
        }

        /// <summary>
        /// lists configurations by category
        /// </summary>
        public string Category {
            get { return (string) Parameters[nameof(Category).ToLower()]; }
            set { Parameters[nameof(Category).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// lists configuration by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid Storageid {
            get { return (Guid) Parameters[nameof(Storageid).ToLower()]; }
            set { Parameters[nameof(Storageid).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Zone to update the parameter value for corresponding zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all configurations.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request);
        Task<ListResponse<ConfigurationResponse>> ListConfigurationsAsync(ListConfigurationsRequest request);
        ListResponse<ConfigurationResponse> ListConfigurationsAllPages(ListConfigurationsRequest request);
        Task<ListResponse<ConfigurationResponse>> ListConfigurationsAllPagesAsync(ListConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request) => _proxy.Request<ListResponse<ConfigurationResponse>>(request);
        public Task<ListResponse<ConfigurationResponse>> ListConfigurationsAsync(ListConfigurationsRequest request) => _proxy.RequestAsync<ListResponse<ConfigurationResponse>>(request);
        public ListResponse<ConfigurationResponse> ListConfigurationsAllPages(ListConfigurationsRequest request) => _proxy.RequestAllPages<ConfigurationResponse>(request);
        public Task<ListResponse<ConfigurationResponse>> ListConfigurationsAllPagesAsync(ListConfigurationsRequest request) => _proxy.RequestAllPagesAsync<ConfigurationResponse>(request);
    }
}
