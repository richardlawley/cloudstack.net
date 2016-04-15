using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalPxeServersRequest : APIListRequest
    {
        public ListBaremetalPxeServersRequest() : base("listBaremetalPxeServers") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Pxe server device ID
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// list baremetal pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalPxeResponse> ListBaremetalPxeServers(ListBaremetalPxeServersRequest request);
        Task<ListResponse<BaremetalPxeResponse>> ListBaremetalPxeServersAsync(ListBaremetalPxeServersRequest request);
        ListResponse<BaremetalPxeResponse> ListBaremetalPxeServersAllPages(ListBaremetalPxeServersRequest request);
        Task<ListResponse<BaremetalPxeResponse>> ListBaremetalPxeServersAllPagesAsync(ListBaremetalPxeServersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalPxeResponse> ListBaremetalPxeServers(ListBaremetalPxeServersRequest request) => _proxy.Request<ListResponse<BaremetalPxeResponse>>(request);
        public Task<ListResponse<BaremetalPxeResponse>> ListBaremetalPxeServersAsync(ListBaremetalPxeServersRequest request) => _proxy.RequestAsync<ListResponse<BaremetalPxeResponse>>(request);
        public ListResponse<BaremetalPxeResponse> ListBaremetalPxeServersAllPages(ListBaremetalPxeServersRequest request) => _proxy.RequestAllPages<BaremetalPxeResponse>(request);
        public Task<ListResponse<BaremetalPxeResponse>> ListBaremetalPxeServersAllPagesAsync(ListBaremetalPxeServersRequest request) => _proxy.RequestAllPagesAsync<BaremetalPxeResponse>(request);
    }
}
