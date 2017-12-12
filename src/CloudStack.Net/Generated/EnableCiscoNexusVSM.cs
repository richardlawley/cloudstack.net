using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableCiscoNexusVSMRequest : APIRequest
    {
        public EnableCiscoNexusVSMRequest() : base("enableCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be enabled
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request);
        Task<AsyncJobResponse> EnableCiscoNexusVSMAsync(EnableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableCiscoNexusVSMAsync(EnableCiscoNexusVSMRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
