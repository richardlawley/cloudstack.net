using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetworkDeviceRequest : APIRequest
    {
        public AddNetworkDeviceRequest() : base("addNetworkDevice") {}

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

    }
    /// <summary>
    /// Adds a network device of one of the following types: ExternalDhcp, ExternalFirewall, ExternalLoadBalancer, PxeServer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkDeviceResponse AddNetworkDevice(AddNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkDeviceResponse AddNetworkDevice(AddNetworkDeviceRequest request) => _proxy.Request<NetworkDeviceResponse>(request);
    }
}
