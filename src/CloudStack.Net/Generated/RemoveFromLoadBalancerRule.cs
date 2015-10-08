using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveFromLoadBalancerRuleRequest : APIRequest
    {
        public RemoveFromLoadBalancerRuleRequest() : base("removeFromLoadBalancerRule") {}

        /// <summary>
        /// The ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list of IDs of the virtual machines that are being removed from the load balancer rule (i.e. virtualMachineIds=1,2,3)
        /// </summary>
        public IList<long> VirtualMachineIds { get; set; }

        /// <summary>
        /// VM ID and IP map, vmidipmap[0].vmid=1 vmidipmap[0].ip=10.1.1.75
        /// </summary>
        public IDictionary<string, string> VmIdIpMap { get; set; }

    }
    /// <summary>
    /// Removes a virtual machine or a list of virtual machines from a load balancer rule.
    /// </summary>
    /// <summary>
    /// Removes a virtual machine or a list of virtual machines from a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveFromLoadBalancerRule(RemoveFromLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveFromLoadBalancerRule(RemoveFromLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
