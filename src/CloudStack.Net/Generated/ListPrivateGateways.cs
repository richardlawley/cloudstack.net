using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPrivateGatewaysRequest : APIRequest
    {
        public ListPrivateGatewaysRequest() : base("listPrivateGateways") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list private gateway by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// list gateways by ip address
        /// </summary>
        public string IpAddress { get; set; }

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

        /// <summary>
        /// list gateways by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// list gateways by vlan
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// list gateways by vpc
        /// </summary>
        public Guid VpcId { get; set; }

    }
    /// <summary>
    /// List private gateways
    /// </summary>
    /// <summary>
    /// List private gateways
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PrivateGatewayResponse> ListPrivateGateways(ListPrivateGatewaysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PrivateGatewayResponse> ListPrivateGateways(ListPrivateGatewaysRequest request) => _proxy.Request<ListResponse<PrivateGatewayResponse>>(request);
    }
}
