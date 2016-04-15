using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetworkDeviceRequest : APIRequest
    {
        public AddNetworkDeviceRequest() : base("addNetworkDevice") {}

        /// <summary>
        /// parameters for network device
        /// </summary>
        public IList<IDictionary<string, object>> Networkdeviceparameterlist {
            get { return GetList<IDictionary<string, object>>(nameof(Networkdeviceparameterlist).ToLower()); }
            set { SetParameterValue(nameof(Networkdeviceparameterlist).ToLower(), value); }
        }

        /// <summary>
        /// Network device type, now supports ExternalDhcp, PxeServer, NetscalerMPXLoadBalancer, NetscalerVPXLoadBalancer, NetscalerSDXLoadBalancer, F5BigIpLoadBalancer, JuniperSRXFirewall, PaloAltoFirewall
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a network device of one of the following types: ExternalDhcp, ExternalFirewall, ExternalLoadBalancer, PxeServer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkDeviceResponse AddNetworkDevice(AddNetworkDeviceRequest request);
        Task<NetworkDeviceResponse> AddNetworkDeviceAsync(AddNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkDeviceResponse AddNetworkDevice(AddNetworkDeviceRequest request) => _proxy.Request<NetworkDeviceResponse>(request);
        public Task<NetworkDeviceResponse> AddNetworkDeviceAsync(AddNetworkDeviceRequest request) => _proxy.RequestAsync<NetworkDeviceResponse>(request);
    }
}
