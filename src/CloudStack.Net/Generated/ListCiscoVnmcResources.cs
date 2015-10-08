using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoVnmcResourcesRequest : APIRequest
    {
        public ListCiscoVnmcResourcesRequest() : base("listCiscoVnmcResources") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Cisco VNMC resource ID
        /// </summary>
        public Guid CiscoVnmcResourceId { get; set; }

    }
    /// <summary>
    /// Lists Cisco VNMC controllers
    /// </summary>
    /// <summary>
    /// Lists Cisco VNMC controllers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request) => _proxy.Request<ListResponse<CiscoVnmcResourceResponse>>(request);
    }
}
