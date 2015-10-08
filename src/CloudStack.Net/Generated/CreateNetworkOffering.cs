using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkOfferingRequest : APIRequest
    {
        public CreateNetworkOfferingRequest() : base("createNetworkOffering") {}

        /// <summary>
        /// the display text of the network offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// guest type of the network offering: Shared or Isolated
        /// </summary>
        public string GuestIptype { get; set; }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string NetworkOfferingName { get; set; }

        /// <summary>
        /// services supported by the network offering
        /// </summary>
        public IList<string> SupportedServices { get; set; }

        /// <summary>
        /// the traffic type for the network offering. Supported type in current release is GUEST only
        /// </summary>
        public string Traffictype { get; set; }

        /// <summary>
        /// the availability of network offering. Default value is Optional
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// true if the network offering is IP conserve mode enabled
        /// </summary>
        public bool? ConserveMode { get; set; }

        /// <summary>
        /// Network offering details in key/value pairs. Supported keys are internallbprovider/publiclbprovider with service provider as a value
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool? EgressDefaultPolicy { get; set; }

        /// <summary>
        /// true if network offering supports persistent networks; defaulted to false if not specified
        /// </summary>
        public bool? IsPersistent { get; set; }

        /// <summary>
        /// if true keepalive will be turned on in the loadbalancer. At the time of writing this has only an effect on haproxy; the mode http and httpclose options are unset in the haproxy conf file.
        /// </summary>
        public bool? KeepAliveEnabled { get; set; }

        /// <summary>
        /// maximum number of concurrent connections supported by the network offering
        /// </summary>
        public int? MaxConnections { get; set; }

        /// <summary>
        /// data transfer rate in megabits per second allowed
        /// </summary>
        public int? NetworkRate { get; set; }

        /// <summary>
        /// desired service capabilities as part of network offering
        /// </summary>
        public IDictionary<string, string> ServiceCapabilitystList { get; set; }

        /// <summary>
        /// the service offering ID used by virtual router provider
        /// </summary>
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IDictionary<string, string> ServiceProviderList { get; set; }

        /// <summary>
        /// true if network offering supports specifying ip ranges; defaulted to false if not specified
        /// </summary>
        public bool? SpecifyIpRanges { get; set; }

        /// <summary>
        /// true if network offering supports vlans
        /// </summary>
        public bool? SpecifyVlan { get; set; }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public string Tags { get; set; }

    }
    /// <summary>
    /// Creates a network offering.
    /// </summary>
    /// <summary>
    /// Creates a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request) => _proxy.Request<NetworkOfferingResponse>(request);
    }
}
