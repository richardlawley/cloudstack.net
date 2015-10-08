using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignToLoadBalancerRuleRequest : APIRequest
    {
        public AssignToLoadBalancerRuleRequest() : base("assignToLoadBalancerRule") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list of IDs of the virtual machine that are being assigned to the load balancer rule(i.e. virtualMachineIds=1,2,3)
        /// </summary>
        public IList<long> VirtualMachineIds { get; set; }

        /// <summary>
        /// VM ID and IP map, vmidipmap[0].vmid=1 vmidipmap[0].ip=10.1.1.75
        /// </summary>
        public IDictionary<string, string> VmIdIpMap { get; set; }

    }
    /// <summary>
    /// Assigns virtual machine or a list of virtual machines to a load balancer rule.
    /// </summary>
    /// <summary>
    /// Assigns virtual machine or a list of virtual machines to a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AssignToLoadBalancerRule(AssignToLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AssignToLoadBalancerRule(AssignToLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
