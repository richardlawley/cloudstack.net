using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListF5LoadBalancersRequest : APIListRequest
    {
        public ListF5LoadBalancersRequest() : base("listF5LoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// f5 load balancer device ID
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
    /// lists F5 load balancer devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<F5LoadBalancerResponse> ListF5LoadBalancers(ListF5LoadBalancersRequest request);
        Task<ListResponse<F5LoadBalancerResponse>> ListF5LoadBalancersAsync(ListF5LoadBalancersRequest request);
        ListResponse<F5LoadBalancerResponse> ListF5LoadBalancersAllPages(ListF5LoadBalancersRequest request);
        Task<ListResponse<F5LoadBalancerResponse>> ListF5LoadBalancersAllPagesAsync(ListF5LoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<F5LoadBalancerResponse> ListF5LoadBalancers(ListF5LoadBalancersRequest request) => _proxy.Request<ListResponse<F5LoadBalancerResponse>>(request);
        public Task<ListResponse<F5LoadBalancerResponse>> ListF5LoadBalancersAsync(ListF5LoadBalancersRequest request) => _proxy.RequestAsync<ListResponse<F5LoadBalancerResponse>>(request);
        public ListResponse<F5LoadBalancerResponse> ListF5LoadBalancersAllPages(ListF5LoadBalancersRequest request) => _proxy.RequestAllPages<F5LoadBalancerResponse>(request);
        public Task<ListResponse<F5LoadBalancerResponse>> ListF5LoadBalancersAllPagesAsync(ListF5LoadBalancersRequest request) => _proxy.RequestAllPagesAsync<F5LoadBalancerResponse>(request);
    }
}
