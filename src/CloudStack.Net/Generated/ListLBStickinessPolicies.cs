using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLBStickinessPoliciesRequest : APIListRequest
    {
        public ListLBStickinessPoliciesRequest() : base("listLBStickinessPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the load balancer stickiness policy
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// the ID of the load balancer rule
        /// </summary>
        public Guid? LbRuleId {
            get { return GetParameterValue<Guid?>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists load balancer stickiness policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LBStickinessResponse> ListLBStickinessPolicies(ListLBStickinessPoliciesRequest request);
        Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAsync(ListLBStickinessPoliciesRequest request);
        ListResponse<LBStickinessResponse> ListLBStickinessPoliciesAllPages(ListLBStickinessPoliciesRequest request);
        Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAllPagesAsync(ListLBStickinessPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LBStickinessResponse> ListLBStickinessPolicies(ListLBStickinessPoliciesRequest request) => Proxy.Request<ListResponse<LBStickinessResponse>>(request);
        public Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAsync(ListLBStickinessPoliciesRequest request) => Proxy.RequestAsync<ListResponse<LBStickinessResponse>>(request);
        public ListResponse<LBStickinessResponse> ListLBStickinessPoliciesAllPages(ListLBStickinessPoliciesRequest request) => Proxy.RequestAllPages<LBStickinessResponse>(request);
        public Task<ListResponse<LBStickinessResponse>> ListLBStickinessPoliciesAllPagesAsync(ListLBStickinessPoliciesRequest request) => Proxy.RequestAllPagesAsync<LBStickinessResponse>(request);
    }
}
