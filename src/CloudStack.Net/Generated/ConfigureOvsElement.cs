using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled {
            get { return (bool) Parameters[nameof(Enabled).ToLower()]; }
            set { Parameters[nameof(Enabled).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Configures an ovs element.
    /// </summary>
    /// <summary>
    /// Configures an ovs element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureOvsElement(ConfigureOvsElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureOvsElement(ConfigureOvsElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
