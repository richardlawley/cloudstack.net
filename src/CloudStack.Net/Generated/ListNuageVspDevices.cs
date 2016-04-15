using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNuageVspDevicesRequest : APIListRequest
    {
        public ListNuageVspDevicesRequest() : base("listNuageVspDevices") {}

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
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the Nuage VSP device ID
        /// </summary>
        public Guid Vspdeviceid {
            get { return GetParameterValue<Guid>(nameof(Vspdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Vspdeviceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Nuage VSP devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request);
        Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAsync(ListNuageVspDevicesRequest request);
        ListResponse<NuageVspDeviceResponse> ListNuageVspDevicesAllPages(ListNuageVspDevicesRequest request);
        Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAllPagesAsync(ListNuageVspDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request) => _proxy.Request<ListResponse<NuageVspDeviceResponse>>(request);
        public Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAsync(ListNuageVspDevicesRequest request) => _proxy.RequestAsync<ListResponse<NuageVspDeviceResponse>>(request);
        public ListResponse<NuageVspDeviceResponse> ListNuageVspDevicesAllPages(ListNuageVspDevicesRequest request) => _proxy.RequestAllPages<NuageVspDeviceResponse>(request);
        public Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAllPagesAsync(ListNuageVspDevicesRequest request) => _proxy.RequestAllPagesAsync<NuageVspDeviceResponse>(request);
    }
}
