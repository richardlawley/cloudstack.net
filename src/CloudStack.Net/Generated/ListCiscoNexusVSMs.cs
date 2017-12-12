using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoNexusVSMsRequest : APIListRequest
    {
        public ListCiscoNexusVSMsRequest() : base("listCiscoNexusVSMs") {}

        /// <summary>
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Retrieves a Cisco Nexus 1000v Virtual Switch Manager device associated with a Cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request);
        Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAsync(ListCiscoNexusVSMsRequest request);
        ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMsAllPages(ListCiscoNexusVSMsRequest request);
        Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAllPagesAsync(ListCiscoNexusVSMsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request) => Proxy.Request<ListResponse<CiscoNexusVSMResponse>>(request);
        public Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAsync(ListCiscoNexusVSMsRequest request) => Proxy.RequestAsync<ListResponse<CiscoNexusVSMResponse>>(request);
        public ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMsAllPages(ListCiscoNexusVSMsRequest request) => Proxy.RequestAllPages<CiscoNexusVSMResponse>(request);
        public Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAllPagesAsync(ListCiscoNexusVSMsRequest request) => Proxy.RequestAllPagesAsync<CiscoNexusVSMResponse>(request);
    }
}
