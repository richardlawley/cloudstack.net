using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force stop the VM. The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Stops an Internal LB vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request);
        Task<AsyncJobResponse> StopInternalLoadBalancerVMAsync(StopInternalLoadBalancerVMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StopInternalLoadBalancerVM(StopInternalLoadBalancerVMRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StopInternalLoadBalancerVMAsync(StopInternalLoadBalancerVMRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
