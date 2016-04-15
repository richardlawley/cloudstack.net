using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListFirewallRulesRequest : APIListRequest
    {
        public ListFirewallRulesRequest() : base("listFirewallRules") {}

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
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// Lists rule with the specified ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of IP address of the firewall services
        /// </summary>
        public Guid IpAddressId {
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
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
        /// list firewall rules for certain network
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
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
    /// Lists all firewall rules for an IP address.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<FirewallResponse> ListFirewallRules(ListFirewallRulesRequest request);
        Task<ListResponse<FirewallResponse>> ListFirewallRulesAsync(ListFirewallRulesRequest request);
        ListResponse<FirewallResponse> ListFirewallRulesAllPages(ListFirewallRulesRequest request);
        Task<ListResponse<FirewallResponse>> ListFirewallRulesAllPagesAsync(ListFirewallRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<FirewallResponse> ListFirewallRules(ListFirewallRulesRequest request) => _proxy.Request<ListResponse<FirewallResponse>>(request);
        public Task<ListResponse<FirewallResponse>> ListFirewallRulesAsync(ListFirewallRulesRequest request) => _proxy.RequestAsync<ListResponse<FirewallResponse>>(request);
        public ListResponse<FirewallResponse> ListFirewallRulesAllPages(ListFirewallRulesRequest request) => _proxy.RequestAllPages<FirewallResponse>(request);
        public Task<ListResponse<FirewallResponse>> ListFirewallRulesAllPagesAsync(ListFirewallRulesRequest request) => _proxy.RequestAllPagesAsync<FirewallResponse>(request);
    }
}
