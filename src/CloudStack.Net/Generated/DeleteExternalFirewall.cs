using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteExternalFirewallRequest : APIRequest
    {
        public DeleteExternalFirewallRequest() : base("deleteExternalFirewall") {}

        /// <summary>
        /// Id of the external firewall appliance.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an external firewall appliance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteExternalFirewall(DeleteExternalFirewallRequest request);
        Task<SuccessResponse> DeleteExternalFirewallAsync(DeleteExternalFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteExternalFirewall(DeleteExternalFirewallRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteExternalFirewallAsync(DeleteExternalFirewallRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
