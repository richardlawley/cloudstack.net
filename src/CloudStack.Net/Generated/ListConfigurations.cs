using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConfigurationsRequest : APIRequest
    {
        public ListConfigurationsRequest() : base("listConfigurations") {}

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// lists configurations by category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// lists configuration by name
        /// </summary>
        public string ConfigName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid StoragePoolId { get; set; }

        /// <summary>
        /// the ID of the Zone to update the parameter value for corresponding zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all configurations.
    /// </summary>
    /// <summary>
    /// Lists all configurations.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request) => _proxy.Request<ListResponse<ConfigurationResponse>>(request);
    }
}
