using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePortForwardingRuleRequest : APIRequest
    {
        public DeletePortForwardingRuleRequest() : base("deletePortForwardingRule") {}

        /// <summary>
        /// the ID of the port forwarding rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a port forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePortForwardingRule(DeletePortForwardingRuleRequest request);
        Task<AsyncJobResponse> DeletePortForwardingRuleAsync(DeletePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePortForwardingRule(DeletePortForwardingRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeletePortForwardingRuleAsync(DeletePortForwardingRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
