using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancerRulesRequest : APIListRequest
    {
        public ListLoadBalancerRulesRequest() : base("listLoadBalancerRules") {}

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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
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
        /// the ID of the load balancer rule
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// the name of the load balancer rule
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list by network ID the rule belongs to
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the public IP address ID of the load balancer rule
        /// </summary>
        public Guid? PublicIpId {
            get { return GetParameterValue<Guid?>(nameof(PublicIpId).ToLower()); }
            set { SetParameterValue(nameof(PublicIpId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine of the load balancer rule
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LoadBalancerResponse> ListLoadBalancerRules(ListLoadBalancerRulesRequest request);
        Task<ListResponse<LoadBalancerResponse>> ListLoadBalancerRulesAsync(ListLoadBalancerRulesRequest request);
        ListResponse<LoadBalancerResponse> ListLoadBalancerRulesAllPages(ListLoadBalancerRulesRequest request);
        Task<ListResponse<LoadBalancerResponse>> ListLoadBalancerRulesAllPagesAsync(ListLoadBalancerRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LoadBalancerResponse> ListLoadBalancerRules(ListLoadBalancerRulesRequest request) => _proxy.Request<ListResponse<LoadBalancerResponse>>(request);
        public Task<ListResponse<LoadBalancerResponse>> ListLoadBalancerRulesAsync(ListLoadBalancerRulesRequest request) => _proxy.RequestAsync<ListResponse<LoadBalancerResponse>>(request);
        public ListResponse<LoadBalancerResponse> ListLoadBalancerRulesAllPages(ListLoadBalancerRulesRequest request) => _proxy.RequestAllPages<LoadBalancerResponse>(request);
        public Task<ListResponse<LoadBalancerResponse>> ListLoadBalancerRulesAllPagesAsync(ListLoadBalancerRulesRequest request) => _proxy.RequestAllPagesAsync<LoadBalancerResponse>(request);
    }
}
