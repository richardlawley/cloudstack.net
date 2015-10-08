using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVpnCustomerGatewaysRequest : APIRequest
    {
        public ListVpnCustomerGatewaysRequest() : base("listVpnCustomerGateways") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// id of the customer gateway
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Lists site to site vpn customer gateways
    /// </summary>
    /// <summary>
    /// Lists site to site vpn customer gateways
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGateways(ListVpnCustomerGatewaysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<Site2SiteCustomerGatewayResponse> ListVpnCustomerGateways(ListVpnCustomerGatewaysRequest request) => _proxy.Request<ListResponse<Site2SiteCustomerGatewayResponse>>(request);
    }
}
