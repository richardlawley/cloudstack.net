using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNuageVspDevicesRequest : APIRequest
    {
        public ListNuageVspDevicesRequest() : base("listNuageVspDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the Nuage VSP device ID
        /// </summary>
        public Guid NuageVspDeviceId { get; set; }

    }
    /// <summary>
    /// Lists Nuage VSP devices
    /// </summary>
    /// <summary>
    /// Lists Nuage VSP devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request) => _proxy.Request<ListResponse<NuageVspDeviceResponse>>(request);
    }
}
