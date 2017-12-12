using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVpnGatewaysRequest : APIListRequest
    {
        public ListVpnGatewaysRequest() : base("listVpnGateways") {}

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
        /// id of the vpn gateway
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
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// id of vpc
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists site 2 site vpn gateways
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<Site2SiteVpnGatewayResponse> ListVpnGateways(ListVpnGatewaysRequest request);
        Task<ListResponse<Site2SiteVpnGatewayResponse>> ListVpnGatewaysAsync(ListVpnGatewaysRequest request);
        ListResponse<Site2SiteVpnGatewayResponse> ListVpnGatewaysAllPages(ListVpnGatewaysRequest request);
        Task<ListResponse<Site2SiteVpnGatewayResponse>> ListVpnGatewaysAllPagesAsync(ListVpnGatewaysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<Site2SiteVpnGatewayResponse> ListVpnGateways(ListVpnGatewaysRequest request) => Proxy.Request<ListResponse<Site2SiteVpnGatewayResponse>>(request);
        public Task<ListResponse<Site2SiteVpnGatewayResponse>> ListVpnGatewaysAsync(ListVpnGatewaysRequest request) => Proxy.RequestAsync<ListResponse<Site2SiteVpnGatewayResponse>>(request);
        public ListResponse<Site2SiteVpnGatewayResponse> ListVpnGatewaysAllPages(ListVpnGatewaysRequest request) => Proxy.RequestAllPages<Site2SiteVpnGatewayResponse>(request);
        public Task<ListResponse<Site2SiteVpnGatewayResponse>> ListVpnGatewaysAllPagesAsync(ListVpnGatewaysRequest request) => Proxy.RequestAllPagesAsync<Site2SiteVpnGatewayResponse>(request);
    }
}
