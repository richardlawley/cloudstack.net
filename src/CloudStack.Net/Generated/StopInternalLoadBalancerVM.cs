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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force stop the VM. The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Stops an Internal LB vm.
    /// </summary>
    /// <summary>
    /// Stops an Internal LB vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
