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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// the value of the configuration
        /// </summary>
        public string Value {
            get { return GetParameterValue<string>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Zone to update the parameter value for corresponding zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        public ConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request) => Proxy.Request<ConfigurationResponse>(request);
        public Task<ConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request) => Proxy.RequestAsync<ConfigurationResponse>(request);
    }
}
