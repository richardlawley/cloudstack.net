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
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid? LbDeviceId {
            get { return GetParameterValue<Guid?>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
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
