using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableCiscoNexusVSMRequest : APIRequest
    {
        public DisableCiscoNexusVSMRequest() : base("disableCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// disable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request);
        Task<AsyncJobResponse> DisableCiscoNexusVSMAsync(DisableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableCiscoNexusVSMAsync(DisableCiscoNexusVSMRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
