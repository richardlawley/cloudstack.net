using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoVnmcResourcesRequest : APIListRequest
    {
        public ListCiscoVnmcResourcesRequest() : base("listCiscoVnmcResources") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Cisco VNMC resource ID
        /// </summary>
        public Guid? Resourceid {
            get { return GetParameterValue<Guid?>(nameof(Resourceid).ToLower()); }
            set { SetParameterValue(nameof(Resourceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Cisco VNMC controllers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request);
        Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAsync(ListCiscoVnmcResourcesRequest request);
        ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResourcesAllPages(ListCiscoVnmcResourcesRequest request);
        Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAllPagesAsync(ListCiscoVnmcResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request) => _proxy.Request<ListResponse<CiscoVnmcResourceResponse>>(request);
        public Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAsync(ListCiscoVnmcResourcesRequest request) => _proxy.RequestAsync<ListResponse<CiscoVnmcResourceResponse>>(request);
        public ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResourcesAllPages(ListCiscoVnmcResourcesRequest request) => _proxy.RequestAllPages<CiscoVnmcResourceResponse>(request);
        public Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAllPagesAsync(ListCiscoVnmcResourcesRequest request) => _proxy.RequestAllPagesAsync<CiscoVnmcResourceResponse>(request);
    }
}
