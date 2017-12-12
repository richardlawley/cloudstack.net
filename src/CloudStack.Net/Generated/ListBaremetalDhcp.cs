using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalDhcpRequest : APIListRequest
    {
        public ListBaremetalDhcpRequest() : base("listBaremetalDhcp") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Type of DHCP device
        /// </summary>
        public string Dhcpservertype {
            get { return GetParameterValue<string>(nameof(Dhcpservertype).ToLower()); }
            set { SetParameterValue(nameof(Dhcpservertype).ToLower(), value); }
        }

        /// <summary>
        /// DHCP server device ID
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
    /// list baremetal dhcp servers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request);
        Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAsync(ListBaremetalDhcpRequest request);
        ListResponse<BaremetalDhcpResponse> ListBaremetalDhcpAllPages(ListBaremetalDhcpRequest request);
        Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAllPagesAsync(ListBaremetalDhcpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request) => Proxy.Request<ListResponse<BaremetalDhcpResponse>>(request);
        public Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAsync(ListBaremetalDhcpRequest request) => Proxy.RequestAsync<ListResponse<BaremetalDhcpResponse>>(request);
        public ListResponse<BaremetalDhcpResponse> ListBaremetalDhcpAllPages(ListBaremetalDhcpRequest request) => Proxy.RequestAllPages<BaremetalDhcpResponse>(request);
        public Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAllPagesAsync(ListBaremetalDhcpRequest request) => Proxy.RequestAllPagesAsync<BaremetalDhcpResponse>(request);
    }
}
