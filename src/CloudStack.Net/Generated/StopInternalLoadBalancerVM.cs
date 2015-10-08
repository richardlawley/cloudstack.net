using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopInternalLoadBalancerVMRequest : APIRequest
    {
        public StopInternalLoadBalancerVMRequest() : base("stopInternalLoadBalancerVM") {}

        /// <summary>
        /// the ID of the internal lb vm
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force stop the VM. The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced { get; set; }

    }
    /// <summary>
    /// Stops an Internal LB vm.
    /// </summary>
    /// <summary>
    /// Stops an Internal LB vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainRouterResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request) => _proxy.Request<DomainRouterResponse>(request);
    }
}
