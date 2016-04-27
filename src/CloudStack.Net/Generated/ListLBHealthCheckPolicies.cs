using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLBHealthCheckPoliciesRequest : APIListRequest
    {
        public ListLBHealthCheckPoliciesRequest() : base("listLBHealthCheckPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the health check policy
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
    /// Lists load balancer health check policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request);
        Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAsync(ListLBHealthCheckPoliciesRequest request);
        ListResponse<LBHealthCheckResponse> ListLBHealthCheckPoliciesAllPages(ListLBHealthCheckPoliciesRequest request);
        Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAllPagesAsync(ListLBHealthCheckPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LBHealthCheckResponse> ListLBHealthCheckPolicies(ListLBHealthCheckPoliciesRequest request) => _proxy.Request<ListResponse<LBHealthCheckResponse>>(request);
        public Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAsync(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAsync<ListResponse<LBHealthCheckResponse>>(request);
        public ListResponse<LBHealthCheckResponse> ListLBHealthCheckPoliciesAllPages(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAllPages<LBHealthCheckResponse>(request);
        public Task<ListResponse<LBHealthCheckResponse>> ListLBHealthCheckPoliciesAllPagesAsync(ListLBHealthCheckPoliciesRequest request) => _proxy.RequestAllPagesAsync<LBHealthCheckResponse>(request);
    }
}
