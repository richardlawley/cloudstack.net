using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteExternalFirewallRequest : APIRequest
    {
        public DeleteExternalFirewallRequest() : base("deleteExternalFirewall") {}

        /// <summary>
        /// Id of the external firewall appliance.
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes an external firewall appliance.
    /// </summary>
    /// <summary>
    /// Deletes an external firewall appliance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteExternalFirewall(DeleteExternalFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteExternalFirewall(DeleteExternalFirewallRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
