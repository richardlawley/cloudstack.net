using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerLoadBalancersRequest : APIRequest
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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
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
    /// <summary>
    /// lists netscaler load balancer devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request) => _proxy.Request<ListResponse<NetscalerLoadBalancerResponse>>(request);
    }
}
