using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBigSwitchBcfDevicesRequest : APIRequest
    {
        public ListBigSwitchBcfDevicesRequest() : base("listBigSwitchBcfDevices") {}

        /// <summary>
        /// bigswitch BCF controller device ID
        /// </summary>
        public Guid BigswitchBcfDeviceId { get; set; }

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

    }
    /// <summary>
    /// Lists BigSwitch BCF Controller devices
    /// </summary>
    /// <summary>
    /// Lists BigSwitch BCF Controller devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevices(ListBigSwitchBcfDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BigSwitchBcfDeviceResponse> ListBigSwitchBcfDevices(ListBigSwitchBcfDevicesRequest request) => _proxy.Request<ListResponse<BigSwitchBcfDeviceResponse>>(request);
    }
}
