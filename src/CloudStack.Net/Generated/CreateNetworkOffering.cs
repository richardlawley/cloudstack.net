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
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// guest type of the network offering: Shared or Isolated
        /// </summary>
        public string GuestIptype {
            get { return (string) Parameters[nameof(GuestIptype).ToLower()]; }
            set { Parameters[nameof(GuestIptype).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// services supported by the network offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return (IList<string>) Parameters[nameof(SupportedServices).ToLower()]; }
            set { Parameters[nameof(SupportedServices).ToLower()] = value; }
        }

        /// <summary>
        /// the traffic type for the network offering. Supported type in current release is GUEST only
        /// </summary>
        public string Traffictype {
            get { return (string) Parameters[nameof(Traffictype).ToLower()]; }
            set { Parameters[nameof(Traffictype).ToLower()] = value; }
        }

        /// <summary>
        /// the availability of network offering. Default value is Optional
        /// </summary>
        public string Availability {
            get { return (string) Parameters[nameof(Availability).ToLower()]; }
            set { Parameters[nameof(Availability).ToLower()] = value; }
        }

        /// <summary>
        /// true if the network offering is IP conserve mode enabled
        /// </summary>
        public bool? ConserveMode {
            get { return (bool?) Parameters[nameof(ConserveMode).ToLower()]; }
            set { Parameters[nameof(ConserveMode).ToLower()] = value; }
        }

        /// <summary>
        /// Network offering details in key/value pairs. Supported keys are internallbprovider/publiclbprovider with service provider as a value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool? EgressDefaultPolicy {
            get { return (bool?) Parameters[nameof(EgressDefaultPolicy).ToLower()]; }
            set { Parameters[nameof(EgressDefaultPolicy).ToLower()] = value; }
        }

        /// <summary>
        /// true if network offering supports persistent networks; defaulted to false if not specified
        /// </summary>
        public bool? IsPersistent {
            get { return (bool?) Parameters[nameof(IsPersistent).ToLower()]; }
            set { Parameters[nameof(IsPersistent).ToLower()] = value; }
        }

        /// <summary>
        /// if true keepalive will be turned on in the loadbalancer. At the time of writing this has only an effect on haproxy; the mode http and httpclose options are unset in the haproxy conf file.
        /// </summary>
        public bool? KeepAliveEnabled {
            get { return (bool?) Parameters[nameof(KeepAliveEnabled).ToLower()]; }
            set { Parameters[nameof(KeepAliveEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// maximum number of concurrent connections supported by the network offering
        /// </summary>
        public int? MaxConnections {
            get { return (int?) Parameters[nameof(MaxConnections).ToLower()]; }
            set { Parameters[nameof(MaxConnections).ToLower()] = value; }
        }

        /// <summary>
        /// data transfer rate in megabits per second allowed
        /// </summary>
        public int? NetworkRate {
            get { return (int?) Parameters[nameof(NetworkRate).ToLower()]; }
            set { Parameters[nameof(NetworkRate).ToLower()] = value; }
        }

        /// <summary>
        /// desired service capabilities as part of network offering
        /// </summary>
        public IList<IDictionary<string, object>> Servicecapabilitylist {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Servicecapabilitylist).ToLower()]; }
            set { Parameters[nameof(Servicecapabilitylist).ToLower()] = value; }
        }

        /// <summary>
        /// the service offering ID used by virtual router provider
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IList<IDictionary<string, object>> ServiceProviderList {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(ServiceProviderList).ToLower()]; }
            set { Parameters[nameof(ServiceProviderList).ToLower()] = value; }
        }

        /// <summary>
        /// true if network offering supports specifying ip ranges; defaulted to false if not specified
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return (bool?) Parameters[nameof(SpecifyIpRanges).ToLower()]; }
            set { Parameters[nameof(SpecifyIpRanges).ToLower()] = value; }
        }

        /// <summary>
        /// true if network offering supports vlans
        /// </summary>
        public bool? SpecifyVlan {
            get { return (bool?) Parameters[nameof(SpecifyVlan).ToLower()]; }
            set { Parameters[nameof(SpecifyVlan).ToLower()] = value; }
        }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public string Tags {
            get { return (string) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
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
