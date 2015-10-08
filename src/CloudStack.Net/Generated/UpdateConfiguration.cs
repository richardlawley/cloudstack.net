using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateConfigurationRequest : APIRequest
    {
        public UpdateConfigurationRequest() : base("updateConfiguration") {}

        /// <summary>
        /// the name of the configuration
        /// </summary>
        public string CfgName { get; set; }

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid StoragePoolId { get; set; }

        /// <summary>
        /// the value of the configuration
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// the ID of the Zone to update the parameter value for corresponding zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Updates a configuration.
    /// </summary>
    /// <summary>
    /// Updates a configuration.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request) => _proxy.Request<ConfigurationResponse>(request);
    }
}
