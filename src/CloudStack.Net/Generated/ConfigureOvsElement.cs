using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureOvsElementRequest : APIRequest
    {
        public ConfigureOvsElementRequest() : base("configureOvsElement") {}

        /// <summary>
        /// the ID of the ovs provider
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled {
            get { return GetParameterValue<bool>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures an ovs element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureOvsElement(ConfigureOvsElementRequest request);
        Task<AsyncJobResponse> ConfigureOvsElementAsync(ConfigureOvsElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureOvsElement(ConfigureOvsElementRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureOvsElementAsync(ConfigureOvsElementRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
