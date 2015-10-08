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
        public Guid Id { get; set; }

        /// <summary>
        /// Enabled/Disabled the service provider
        /// </summary>
        public bool Enabled { get; set; }

    }
    /// <summary>
    /// Configures an ovs element.
    /// </summary>
    /// <summary>
    /// Configures an ovs element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OvsProviderResponse ConfigureOvsElement(ConfigureOvsElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OvsProviderResponse ConfigureOvsElement(ConfigureOvsElementRequest request) => _proxy.Request<OvsProviderResponse>(request);
    }
}
