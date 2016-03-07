using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerLoadBalancersRequest : APIListRequest
    {
        public ListNetscalerLoadBalancersRequest() : base("listNetscalerLoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return (Guid) Parameters[nameof(LbDeviceId).ToLower()]; }
            set { Parameters[nameof(LbDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// lists netscaler load balancer devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request);
        Task<ListResponse<NetscalerLoadBalancerResponse>> ListNetscalerLoadBalancersAsync(ListNetscalerLoadBalancersRequest request);
        ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancersAllPages(ListNetscalerLoadBalancersRequest request);
        Task<ListResponse<NetscalerLoadBalancerResponse>> ListNetscalerLoadBalancersAllPagesAsync(ListNetscalerLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request) => _proxy.Request<ListResponse<NetscalerLoadBalancerResponse>>(request);
        public Task<ListResponse<NetscalerLoadBalancerResponse>> ListNetscalerLoadBalancersAsync(ListNetscalerLoadBalancersRequest request) => _proxy.RequestAsync<ListResponse<NetscalerLoadBalancerResponse>>(request);
        public ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancersAllPages(ListNetscalerLoadBalancersRequest request) => _proxy.RequestAllPages<NetscalerLoadBalancerResponse>(request);
        public Task<ListResponse<NetscalerLoadBalancerResponse>> ListNetscalerLoadBalancersAllPagesAsync(ListNetscalerLoadBalancersRequest request) => _proxy.RequestAllPagesAsync<NetscalerLoadBalancerResponse>(request);
    }
}
