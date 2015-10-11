using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartInternalLoadBalancerVMRequest : APIRequest
    {
        public StartInternalLoadBalancerVMRequest() : base("startInternalLoadBalancerVM") {}

        /// <summary>
        /// the ID of the internal lb vm
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Starts an existing internal lb vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartInternalLoadBalancerVM(StartInternalLoadBalancerVMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartInternalLoadBalancerVM(StartInternalLoadBalancerVMRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
