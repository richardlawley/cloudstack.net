using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBigSwitchBcfDevicesRequest : APIListRequest
    {
        public ListBigSwitchBcfDevicesRequest() : base("listBigSwitchBcfDevices") {}

        /// <summary>
        /// bigswitch BCF controller device ID
        /// </summary>
        public Guid? Bcfdeviceid {
            get { return GetParameterValue<Guid?>(nameof(Bcfdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Bcfdeviceid).ToLower(), value); }
        }

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

    }
    /// <summary>
    /// Lists BigSwitch BCF Controller devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevices(ListBigSwitchBcfDevicesRequest request);
        Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAsync(ListBigSwitchBcfDevicesRequest request);
        ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevicesAllPages(ListBigSwitchBcfDevicesRequest request);
        Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAllPagesAsync(ListBigSwitchBcfDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevices(ListBigSwitchBcfDevicesRequest request) => Proxy.Request<ListResponse<BigSwitchBcfDeviceResponse>>(request);
        public Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAsync(ListBigSwitchBcfDevicesRequest request) => Proxy.RequestAsync<ListResponse<BigSwitchBcfDeviceResponse>>(request);
        public ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevicesAllPages(ListBigSwitchBcfDevicesRequest request) => Proxy.RequestAllPages<BigSwitchBcfDeviceResponse>(request);
        public Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAllPagesAsync(ListBigSwitchBcfDevicesRequest request) => Proxy.RequestAllPagesAsync<BigSwitchBcfDeviceResponse>(request);
    }
}
