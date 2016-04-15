using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListGlobalLoadBalancerRulesRequest : APIListRequest
    {
        public ListGlobalLoadBalancerRulesRequest() : base("listGlobalLoadBalancerRules") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// region ID
        /// </summary>
        public int? RegionId {
            get { return GetParameterValue<int?>(nameof(RegionId).ToLower()); }
            set { SetParameterValue(nameof(RegionId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GlobalLoadBalancerResponse> ListGlobalLoadBalancerRules(ListGlobalLoadBalancerRulesRequest request);
        Task<ListResponse<GlobalLoadBalancerResponse>> ListGlobalLoadBalancerRulesAsync(ListGlobalLoadBalancerRulesRequest request);
        ListResponse<GlobalLoadBalancerResponse> ListGlobalLoadBalancerRulesAllPages(ListGlobalLoadBalancerRulesRequest request);
        Task<ListResponse<GlobalLoadBalancerResponse>> ListGlobalLoadBalancerRulesAllPagesAsync(ListGlobalLoadBalancerRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GlobalLoadBalancerResponse> ListGlobalLoadBalancerRules(ListGlobalLoadBalancerRulesRequest request) => _proxy.Request<ListResponse<GlobalLoadBalancerResponse>>(request);
        public Task<ListResponse<GlobalLoadBalancerResponse>> ListGlobalLoadBalancerRulesAsync(ListGlobalLoadBalancerRulesRequest request) => _proxy.RequestAsync<ListResponse<GlobalLoadBalancerResponse>>(request);
        public ListResponse<GlobalLoadBalancerResponse> ListGlobalLoadBalancerRulesAllPages(ListGlobalLoadBalancerRulesRequest request) => _proxy.RequestAllPages<GlobalLoadBalancerResponse>(request);
        public Task<ListResponse<GlobalLoadBalancerResponse>> ListGlobalLoadBalancerRulesAllPagesAsync(ListGlobalLoadBalancerRulesRequest request) => _proxy.RequestAllPagesAsync<GlobalLoadBalancerResponse>(request);
    }
}
