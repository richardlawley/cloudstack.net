using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVpnCustomerGatewaysRequest : APIListRequest
    {
        public ListVpnCustomerGatewaysRequest() : base("listVpnCustomerGateways") {}

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
        /// id of the customer gateway
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

    }
    /// <summary>
    /// Lists site to site vpn customer gateways
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGateways(ListVpnCustomerGatewaysRequest request);
        Task<ListResponse<Site2SiteCustomerGatewayResponse>> ListVpnCustomerGatewaysAsync(ListVpnCustomerGatewaysRequest request);
        ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGatewaysAllPages(ListVpnCustomerGatewaysRequest request);
        Task<ListResponse<Site2SiteCustomerGatewayResponse>> ListVpnCustomerGatewaysAllPagesAsync(ListVpnCustomerGatewaysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGateways(ListVpnCustomerGatewaysRequest request) => _proxy.Request<ListResponse<Site2SiteCustomerGatewayResponse>>(request);
        public Task<ListResponse<Site2SiteCustomerGatewayResponse>> ListVpnCustomerGatewaysAsync(ListVpnCustomerGatewaysRequest request) => _proxy.RequestAsync<ListResponse<Site2SiteCustomerGatewayResponse>>(request);
        public ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGatewaysAllPages(ListVpnCustomerGatewaysRequest request) => _proxy.RequestAllPages<Site2SiteCustomerGatewayResponse>(request);
        public Task<ListResponse<Site2SiteCustomerGatewayResponse>> ListVpnCustomerGatewaysAllPagesAsync(ListVpnCustomerGatewaysRequest request) => _proxy.RequestAllPagesAsync<Site2SiteCustomerGatewayResponse>(request);
    }
}
