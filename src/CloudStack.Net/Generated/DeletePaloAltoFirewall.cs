using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePaloAltoFirewallRequest : APIRequest
    {
        public DeletePaloAltoFirewallRequest() : base("deletePaloAltoFirewall") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return GetParameterValue<Guid>(nameof(FwDeviceId).ToLower()); }
            set { SetParameterValue(nameof(FwDeviceId).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePaloAltoFirewall(DeletePaloAltoFirewallRequest request);
        Task<AsyncJobResponse> DeletePaloAltoFirewallAsync(DeletePaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePaloAltoFirewall(DeletePaloAltoFirewallRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeletePaloAltoFirewallAsync(DeletePaloAltoFirewallRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
