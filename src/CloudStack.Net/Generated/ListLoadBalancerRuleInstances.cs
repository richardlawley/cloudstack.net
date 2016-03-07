using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancerRuleInstancesRequest : APIListRequest
    {
        public ListLoadBalancerRuleInstancesRequest() : base("listLoadBalancerRuleInstances") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// true if listing all virtual machines currently applied to the load balancer rule; default is true
        /// </summary>
        public bool? Applied {
            get { return (bool?) Parameters[nameof(Applied).ToLower()]; }
            set { Parameters[nameof(Applied).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// true if load balancer rule VM IP information to be included; default is false
        /// </summary>
        public bool? Lbvmips {
            get { return (bool?) Parameters[nameof(Lbvmips).ToLower()]; }
            set { Parameters[nameof(Lbvmips).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List all virtual machine instances that are assigned to a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request);
        Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAsync(ListLoadBalancerRuleInstancesRequest request);
        ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstancesAllPages(ListLoadBalancerRuleInstancesRequest request);
        Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAllPagesAsync(ListLoadBalancerRuleInstancesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request) => _proxy.Request<ListResponse<LoadBalancerRuleVmMapResponse>>(request);
        public Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAsync(ListLoadBalancerRuleInstancesRequest request) => _proxy.RequestAsync<ListResponse<LoadBalancerRuleVmMapResponse>>(request);
        public ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstancesAllPages(ListLoadBalancerRuleInstancesRequest request) => _proxy.RequestAllPages<LoadBalancerRuleVmMapResponse>(request);
        public Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAllPagesAsync(ListLoadBalancerRuleInstancesRequest request) => _proxy.RequestAllPagesAsync<LoadBalancerRuleVmMapResponse>(request);
    }
}
