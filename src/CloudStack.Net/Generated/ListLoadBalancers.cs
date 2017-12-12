using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancersRequest : APIListRequest
    {
        public ListLoadBalancersRequest() : base("listLoadBalancers") {}

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
        /// the ID of the load balancer
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
        /// the name of the load balancer
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the network ID of the load balancer
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
        /// the scheme of the load balancer. Supported value is internal in the current release
        /// </summary>
        public string Scheme {
            get { return GetParameterValue<string>(nameof(Scheme).ToLower()); }
            set { SetParameterValue(nameof(Scheme).ToLower(), value); }
        }

        /// <summary>
        /// the source IP address of the load balancer
        /// </summary>
        public string Sourceipaddress {
            get { return GetParameterValue<string>(nameof(Sourceipaddress).ToLower()); }
            set { SetParameterValue(nameof(Sourceipaddress).ToLower(), value); }
        }

        /// <summary>
        /// the network ID of the source IP address
        /// </summary>
        public Guid? Sourceipaddressnetworkid {
            get { return GetParameterValue<Guid?>(nameof(Sourceipaddressnetworkid).ToLower()); }
            set { SetParameterValue(nameof(Sourceipaddressnetworkid).ToLower(), value); }
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
    /// Lists load balancers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancers(ListLoadBalancersRequest request);
        Task<ListResponse<ApplicationLoadBalancerResponse>> ListLoadBalancersAsync(ListLoadBalancersRequest request);
        ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancersAllPages(ListLoadBalancersRequest request);
        Task<ListResponse<ApplicationLoadBalancerResponse>> ListLoadBalancersAllPagesAsync(ListLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancers(ListLoadBalancersRequest request) => Proxy.Request<ListResponse<ApplicationLoadBalancerResponse>>(request);
        public Task<ListResponse<ApplicationLoadBalancerResponse>> ListLoadBalancersAsync(ListLoadBalancersRequest request) => Proxy.RequestAsync<ListResponse<ApplicationLoadBalancerResponse>>(request);
        public ListResponse<ApplicationLoadBalancerResponse> ListLoadBalancersAllPages(ListLoadBalancersRequest request) => Proxy.RequestAllPages<ApplicationLoadBalancerResponse>(request);
        public Task<ListResponse<ApplicationLoadBalancerResponse>> ListLoadBalancersAllPagesAsync(ListLoadBalancersRequest request) => Proxy.RequestAllPagesAsync<ApplicationLoadBalancerResponse>(request);
    }
}
