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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the list of IDs of the virtual machine that are being assigned to the load balancer rule(i.e. virtualMachineIds=1,2,3)
        /// </summary>
        public IList<Guid> VirtualMachineIds {
            get { return GetList<Guid>(nameof(VirtualMachineIds).ToLower()); }
            set { Parameters[nameof(VirtualMachineIds).ToLower()] = value; }
        }

        /// <summary>
        /// VM ID and IP map, vmidipmap[0].vmid=1 vmidipmap[0].ip=10.1.1.75
        /// </summary>
        public IList<IDictionary<string, object>> VmIdIpMap {
            get { return GetList<IDictionary<string, object>>(nameof(VmIdIpMap).ToLower()); }
            set { Parameters[nameof(VmIdIpMap).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Assigns virtual machine or a list of virtual machines to a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignToLoadBalancerRule(AssignToLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignToLoadBalancerRule(AssignToLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
