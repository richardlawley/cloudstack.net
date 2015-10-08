using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkDeviceRequest : APIRequest
    {
        public ListNetworkDeviceRequest() : base("listNetworkDevice") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// parameters for network device
        /// </summary>
        public IDictionary<string, string> ParamList { get; set; }

        /// <summary>
        /// Network device type, now supports ExternalDhcp, PxeServer, NetscalerMPXLoadBalancer, NetscalerVPXLoadBalancer, NetscalerSDXLoadBalancer, F5BigIpLoadBalancer, JuniperSRXFirewall, PaloAltoFirewall
        /// </summary>
        public string Type { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List network devices
    /// </summary>
    /// <summary>
    /// List network devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkDeviceResponse> ListNetworkDevice(ListNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkDeviceResponse> ListNetworkDevice(ListNetworkDeviceRequest request) => _proxy.Request<ListResponse<NetworkDeviceResponse>>(request);
    }
}
