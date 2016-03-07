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
        public Guid Bcfdeviceid {
            get { return (Guid) Parameters[nameof(Bcfdeviceid).ToLower()]; }
            set { Parameters[nameof(Bcfdeviceid).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
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
        public ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevices(ListBigSwitchBcfDevicesRequest request) => _proxy.Request<ListResponse<BigSwitchBcfDeviceResponse>>(request);
        public Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAsync(ListBigSwitchBcfDevicesRequest request) => _proxy.RequestAsync<ListResponse<BigSwitchBcfDeviceResponse>>(request);
        public ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevicesAllPages(ListBigSwitchBcfDevicesRequest request) => _proxy.RequestAllPages<BigSwitchBcfDeviceResponse>(request);
        public Task<ListResponse<BigSwitchBcfDeviceResponse>> ListBigSwitchBcfDevicesAllPagesAsync(ListBigSwitchBcfDevicesRequest request) => _proxy.RequestAllPagesAsync<BigSwitchBcfDeviceResponse>(request);
    }
}
