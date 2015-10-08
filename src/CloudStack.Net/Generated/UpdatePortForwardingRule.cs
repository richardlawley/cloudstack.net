using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePortForwardingRuleRequest : APIRequest
    {
        public UpdatePortForwardingRuleRequest() : base("updatePortForwardingRule") {}

        /// <summary>
        /// the ID of the port forwarding rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the private port of the port forwarding rule
        /// </summary>
        public int? PrivatePort { get; set; }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// VM guest nic Secondary ip address for the port forwarding rule
        /// </summary>
        public string VmGuestIp { get; set; }

    }
    /// <summary>
    /// Updates a port forwarding rule. Only the private port and the virtual machine can be updated.
    /// </summary>
    /// <summary>
    /// Updates a port forwarding rule. Only the private port and the virtual machine can be updated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallRuleResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallRuleResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request) => _proxy.Request<FirewallRuleResponse>(request);
    }
}
