using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListInternalLoadBalancerElementsRequest : APIListRequest
    {
        public ListInternalLoadBalancerElementsRequest() : base("listInternalLoadBalancerElements") {}

        /// <summary>
        /// list internal load balancer elements by enabled state
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// list internal load balancer elements by id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list internal load balancer elements by network service provider id
        /// </summary>
        public Guid NspId {
            get { return GetParameterValue<Guid>(nameof(NspId).ToLower()); }
            set { SetParameterValue(nameof(NspId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available Internal Load Balancer elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElements(ListInternalLoadBalancerElementsRequest request);
        Task<ListResponse<InternalLoadBalancerElementResponse>> ListInternalLoadBalancerElementsAsync(ListInternalLoadBalancerElementsRequest request);
        ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElementsAllPages(ListInternalLoadBalancerElementsRequest request);
        Task<ListResponse<InternalLoadBalancerElementResponse>> ListInternalLoadBalancerElementsAllPagesAsync(ListInternalLoadBalancerElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElements(ListInternalLoadBalancerElementsRequest request) => _proxy.Request<ListResponse<InternalLoadBalancerElementResponse>>(request);
        public Task<ListResponse<InternalLoadBalancerElementResponse>> ListInternalLoadBalancerElementsAsync(ListInternalLoadBalancerElementsRequest request) => _proxy.RequestAsync<ListResponse<InternalLoadBalancerElementResponse>>(request);
        public ListResponse<InternalLoadBalancerElementResponse> ListInternalLoadBalancerElementsAllPages(ListInternalLoadBalancerElementsRequest request) => _proxy.RequestAllPages<InternalLoadBalancerElementResponse>(request);
        public Task<ListResponse<InternalLoadBalancerElementResponse>> ListInternalLoadBalancerElementsAllPagesAsync(ListInternalLoadBalancerElementsRequest request) => _proxy.RequestAllPagesAsync<InternalLoadBalancerElementResponse>(request);
    }
}
