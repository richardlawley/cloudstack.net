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
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// parameters for network device
        /// </summary>
        public IDictionary<string, string> Networkdeviceparameterlist {
            get { return (IDictionary<string, string>) Parameters[nameof(Networkdeviceparameterlist).ToLower()]; }
            set { Parameters[nameof(Networkdeviceparameterlist).ToLower()] = value; }
        }

        /// <summary>
        /// Network device type, now supports ExternalDhcp, PxeServer, NetscalerMPXLoadBalancer, NetscalerVPXLoadBalancer, NetscalerSDXLoadBalancer, F5BigIpLoadBalancer, JuniperSRXFirewall, PaloAltoFirewall
        /// </summary>
        public string Networkdevicetype {
            get { return (string) Parameters[nameof(Networkdevicetype).ToLower()]; }
            set { Parameters[nameof(Networkdevicetype).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

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
