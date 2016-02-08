using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateConfigurationRequest : APIRequest
    {
        public UpdateConfigurationRequest() : base("updateConfiguration") {}

        /// <summary>
        /// the name of the configuration
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid AccountId {
            get { return (Guid) Parameters[nameof(AccountId).ToLower()]; }
            set { Parameters[nameof(AccountId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid Storageid {
            get { return (Guid) Parameters[nameof(Storageid).ToLower()]; }
            set { Parameters[nameof(Storageid).ToLower()] = value; }
        }

        /// <summary>
        /// the value of the configuration
        /// </summary>
        public string Value {
            get { return (string) Parameters[nameof(Value).ToLower()]; }
            set { Parameters[nameof(Value).ToLower()] = value; }
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
    /// Updates a configuration.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);
        Task<ConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request) => _proxy.Request<ConfigurationResponse>(request);
        public Task<ConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request) => _proxy.RequestAsync<ConfigurationResponse>(request);
    }
}
