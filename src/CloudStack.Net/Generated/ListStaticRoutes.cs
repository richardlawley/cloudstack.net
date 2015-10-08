using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStaticRoutesRequest : APIRequest
    {
        public ListStaticRoutesRequest() : base("listStaticRoutes") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list static routes by gateway id
        /// </summary>
        public Guid GatewayId { get; set; }

        /// <summary>
        /// list static route by id
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

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// list static routes by vpc id
        /// </summary>
        public Guid VpcId { get; set; }

    }
    /// <summary>
    /// Lists all static routes
    /// </summary>
    /// <summary>
    /// Lists all static routes
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StaticRouteResponse> ListStaticRoutes(ListStaticRoutesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StaticRouteResponse> ListStaticRoutes(ListStaticRoutesRequest request) => _proxy.Request<ListResponse<StaticRouteResponse>>(request);
    }
}
