using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNiciraNvpDeviceNetworksRequest : APIListRequest
    {
        public ListNiciraNvpDeviceNetworksRequest() : base("listNiciraNvpDeviceNetworks") {}

        /// <summary>
        /// nicira nvp device ID
        /// </summary>
        public Guid Nvpdeviceid {
            get { return GetParameterValue<Guid>(nameof(Nvpdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Nvpdeviceid).ToLower(), value); }
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
    /// lists network that are using a nicira nvp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworks(ListNiciraNvpDeviceNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNiciraNvpDeviceNetworksAsync(ListNiciraNvpDeviceNetworksRequest request);
        ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworksAllPages(ListNiciraNvpDeviceNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNiciraNvpDeviceNetworksAllPagesAsync(ListNiciraNvpDeviceNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworks(ListNiciraNvpDeviceNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListNiciraNvpDeviceNetworksAsync(ListNiciraNvpDeviceNetworksRequest request) => _proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworksAllPages(ListNiciraNvpDeviceNetworksRequest request) => _proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListNiciraNvpDeviceNetworksAllPagesAsync(ListNiciraNvpDeviceNetworksRequest request) => _proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
