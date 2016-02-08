using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoVnmcResourcesRequest : APIRequest
    {
        public ListCiscoVnmcResourcesRequest() : base("listCiscoVnmcResources") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Cisco VNMC resource ID
        /// </summary>
        public Guid Resourceid {
            get { return (Guid) Parameters[nameof(Resourceid).ToLower()]; }
            set { Parameters[nameof(Resourceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Cisco VNMC controllers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request);
        Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAsync(ListCiscoVnmcResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoVnmcResourceResponse> ListCiscoVnmcResources(ListCiscoVnmcResourcesRequest request) => _proxy.Request<ListResponse<CiscoVnmcResourceResponse>>(request);
        public Task<ListResponse<CiscoVnmcResourceResponse>> ListCiscoVnmcResourcesAsync(ListCiscoVnmcResourcesRequest request) => _proxy.RequestAsync<ListResponse<CiscoVnmcResourceResponse>>(request);
    }
}
