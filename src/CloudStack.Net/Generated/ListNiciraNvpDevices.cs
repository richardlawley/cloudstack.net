using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNiciraNvpDevicesRequest : APIRequest
    {
        public ListNiciraNvpDevicesRequest() : base("listNiciraNvpDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// nicira nvp device ID
        /// </summary>
        public Guid NiciraNvpDeviceId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

    }
    /// <summary>
    /// Lists Nicira NVP devices
    /// </summary>
    /// <summary>
    /// Lists Nicira NVP devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevices(ListNiciraNvpDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NiciraNvpDeviceResponse> ListNiciraNvpDevices(ListNiciraNvpDevicesRequest request) => _proxy.Request<ListResponse<NiciraNvpDeviceResponse>>(request);
    }
}
