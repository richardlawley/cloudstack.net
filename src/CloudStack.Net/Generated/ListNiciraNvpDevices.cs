using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNiciraNvpDevicesRequest : APIListRequest
    {
        public ListNiciraNvpDevicesRequest() : base("listNiciraNvpDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// nicira nvp device ID
        /// </summary>
        public Guid? Nvpdeviceid {
            get { return GetParameterValue<Guid?>(nameof(Nvpdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Nvpdeviceid).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Nicira NVP devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevices(ListNiciraNvpDevicesRequest request);
        Task<ListResponse<NiciraNvpDeviceResponse>> ListNiciraNvpDevicesAsync(ListNiciraNvpDevicesRequest request);
        ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevicesAllPages(ListNiciraNvpDevicesRequest request);
        Task<ListResponse<NiciraNvpDeviceResponse>> ListNiciraNvpDevicesAllPagesAsync(ListNiciraNvpDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevices(ListNiciraNvpDevicesRequest request) => _proxy.Request<ListResponse<NiciraNvpDeviceResponse>>(request);
        public Task<ListResponse<NiciraNvpDeviceResponse>> ListNiciraNvpDevicesAsync(ListNiciraNvpDevicesRequest request) => _proxy.RequestAsync<ListResponse<NiciraNvpDeviceResponse>>(request);
        public ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevicesAllPages(ListNiciraNvpDevicesRequest request) => _proxy.RequestAllPages<NiciraNvpDeviceResponse>(request);
        public Task<ListResponse<NiciraNvpDeviceResponse>> ListNiciraNvpDevicesAllPagesAsync(ListNiciraNvpDevicesRequest request) => _proxy.RequestAllPagesAsync<NiciraNvpDeviceResponse>(request);
    }
}
