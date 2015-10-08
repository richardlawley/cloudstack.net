using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoAsa1000vResourcesRequest : APIRequest
    {
        public ListCiscoAsa1000vResourcesRequest() : base("listCiscoAsa1000vResources") {}

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Host { get; set; }

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
        /// Cisco ASA 1000v resource ID
        /// </summary>
        public Guid CiscoAsa1000vResourceId { get; set; }

    }
    /// <summary>
    /// Lists Cisco ASA 1000v appliances
    /// </summary>
    /// <summary>
    /// Lists Cisco ASA 1000v appliances
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request) => _proxy.Request<ListResponse<CiscoAsa1000vResourceResponse>>(request);
    }
}
