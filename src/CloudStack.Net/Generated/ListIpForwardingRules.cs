using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIpForwardingRulesRequest : APIListRequest
    {
        public ListIpForwardingRulesRequest() : base("listIpForwardingRules") {}

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
        /// Lists rule with the specified ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// list the rule belonging to this public IP address
        /// </summary>
        public Guid Ipaddressid {
            get { return GetParameterValue<Guid>(nameof(Ipaddressid).ToLower()); }
            set { SetParameterValue(nameof(Ipaddressid).ToLower(), value); }
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
        /// Lists all rules applied to the specified VM.
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// List the IP forwarding rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<FirewallRuleResponse> ListIpForwardingRules(ListIpForwardingRulesRequest request);
        Task<ListResponse<FirewallRuleResponse>> ListIpForwardingRulesAsync(ListIpForwardingRulesRequest request);
        ListResponse<FirewallRuleResponse> ListIpForwardingRulesAllPages(ListIpForwardingRulesRequest request);
        Task<ListResponse<FirewallRuleResponse>> ListIpForwardingRulesAllPagesAsync(ListIpForwardingRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<FirewallRuleResponse> ListIpForwardingRules(ListIpForwardingRulesRequest request) => _proxy.Request<ListResponse<FirewallRuleResponse>>(request);
        public Task<ListResponse<FirewallRuleResponse>> ListIpForwardingRulesAsync(ListIpForwardingRulesRequest request) => _proxy.RequestAsync<ListResponse<FirewallRuleResponse>>(request);
        public ListResponse<FirewallRuleResponse> ListIpForwardingRulesAllPages(ListIpForwardingRulesRequest request) => _proxy.RequestAllPages<FirewallRuleResponse>(request);
        public Task<ListResponse<FirewallRuleResponse>> ListIpForwardingRulesAllPagesAsync(ListIpForwardingRulesRequest request) => _proxy.RequestAllPagesAsync<FirewallRuleResponse>(request);
    }
}
