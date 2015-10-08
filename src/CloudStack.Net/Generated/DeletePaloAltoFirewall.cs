using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePaloAltoFirewallRequest : APIRequest
    {
        public DeletePaloAltoFirewallRequest() : base("deletePaloAltoFirewall") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a Palo Alto firewall device
    /// </summary>
    /// <summary>
    ///  delete a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeletePaloAltoFirewall(DeletePaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeletePaloAltoFirewall(DeletePaloAltoFirewallRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
