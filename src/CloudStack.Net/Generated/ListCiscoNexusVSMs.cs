using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoNexusVSMsRequest : APIRequest
    {
        public ListCiscoNexusVSMsRequest() : base("listCiscoNexusVSMs") {}

        /// <summary>
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Retrieves a Cisco Nexus 1000v Virtual Switch Manager device associated with a Cluster
    /// </summary>
    /// <summary>
    /// Retrieves a Cisco Nexus 1000v Virtual Switch Manager device associated with a Cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request) => _proxy.Request<ListResponse<CiscoNexusVSMResponse>>(request);
    }
}
