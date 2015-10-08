using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRoutersRequest : APIRequest
    {
        public ListRoutersRequest() : base("listRouters") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the cluster ID of the router
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// if true is passed for this parameter, list only VPC routers
        /// </summary>
        public bool? ForVpc { get; set; }

        /// <summary>
        /// the host ID of the router
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the ID of the disk router
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

        /// <summary>
        /// the name of the router
        /// </summary>
        public string RouterName { get; set; }

        /// <summary>
        /// list by network id
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Pod ID of the router
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the state of the router
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// list virtual router elements by version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// List networks by VPC
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// the Zone ID of the router
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List routers.
    /// </summary>
    /// <summary>
    /// List routers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainRouterResponse> ListRouters(ListRoutersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainRouterResponse> ListRouters(ListRoutersRequest request) => _proxy.Request<ListResponse<DomainRouterResponse>>(request);
    }
}
