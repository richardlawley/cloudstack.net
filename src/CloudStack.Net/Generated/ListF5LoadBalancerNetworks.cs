using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListF5LoadBalancerNetworksRequest : APIRequest
    {
        public ListF5LoadBalancerNetworksRequest() : base("listF5LoadBalancerNetworks") {}

        /// <summary>
        /// f5 load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return (Guid) Parameters[nameof(LbDeviceId).ToLower()]; }
            set { Parameters[nameof(LbDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// lists network that are using a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListF5LoadBalancerNetworks(ListF5LoadBalancerNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListF5LoadBalancerNetworksAsync(ListF5LoadBalancerNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListF5LoadBalancerNetworks(ListF5LoadBalancerNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListF5LoadBalancerNetworksAsync(ListF5LoadBalancerNetworksRequest request) => _proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
    }
}
