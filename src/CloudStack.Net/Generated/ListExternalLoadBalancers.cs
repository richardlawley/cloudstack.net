using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListExternalLoadBalancersRequest : APIListRequest
    {
        public ListExternalLoadBalancersRequest() : base("listExternalLoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists F5 external load balancer appliances added in a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostResponse> ListExternalLoadBalancers(ListExternalLoadBalancersRequest request);
        Task<ListResponse<HostResponse>> ListExternalLoadBalancersAsync(ListExternalLoadBalancersRequest request);
        ListResponse<HostResponse> ListExternalLoadBalancersAllPages(ListExternalLoadBalancersRequest request);
        Task<ListResponse<HostResponse>> ListExternalLoadBalancersAllPagesAsync(ListExternalLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostResponse> ListExternalLoadBalancers(ListExternalLoadBalancersRequest request) => _proxy.Request<ListResponse<HostResponse>>(request);
        public Task<ListResponse<HostResponse>> ListExternalLoadBalancersAsync(ListExternalLoadBalancersRequest request) => _proxy.RequestAsync<ListResponse<HostResponse>>(request);
        public ListResponse<HostResponse> ListExternalLoadBalancersAllPages(ListExternalLoadBalancersRequest request) => _proxy.RequestAllPages<HostResponse>(request);
        public Task<ListResponse<HostResponse>> ListExternalLoadBalancersAllPagesAsync(ListExternalLoadBalancersRequest request) => _proxy.RequestAllPagesAsync<HostResponse>(request);
    }
}
