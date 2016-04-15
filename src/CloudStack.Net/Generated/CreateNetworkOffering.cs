using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// guest type of the network offering: Shared or Isolated
        /// </summary>
        public string GuestIptype {
            get { return GetParameterValue<string>(nameof(GuestIptype).ToLower()); }
            set { SetParameterValue(nameof(GuestIptype).ToLower(), value); }
        }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// services supported by the network offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// the traffic type for the network offering. Supported type in current release is GUEST only
        /// </summary>
        public string Traffictype {
            get { return GetParameterValue<string>(nameof(Traffictype).ToLower()); }
            set { SetParameterValue(nameof(Traffictype).ToLower(), value); }
        }

        /// <summary>
        /// the availability of network offering. Default value is Optional
        /// </summary>
        public string Availability {
            get { return GetParameterValue<string>(nameof(Availability).ToLower()); }
            set { SetParameterValue(nameof(Availability).ToLower(), value); }
        }

        /// <summary>
        /// true if the network offering is IP conserve mode enabled
        /// </summary>
        public bool? ConserveMode {
            get { return GetParameterValue<bool?>(nameof(ConserveMode).ToLower()); }
            set { SetParameterValue(nameof(ConserveMode).ToLower(), value); }
        }

        /// <summary>
        /// Network offering details in key/value pairs. Supported keys are internallbprovider/publiclbprovider with service provider as a value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool? EgressDefaultPolicy {
            get { return GetParameterValue<bool?>(nameof(EgressDefaultPolicy).ToLower()); }
            set { SetParameterValue(nameof(EgressDefaultPolicy).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports persistent networks; defaulted to false if not specified
        /// </summary>
        public bool? IsPersistent {
            get { return GetParameterValue<bool?>(nameof(IsPersistent).ToLower()); }
            set { SetParameterValue(nameof(IsPersistent).ToLower(), value); }
        }

        /// <summary>
        /// if true keepalive will be turned on in the loadbalancer. At the time of writing this has only an effect on haproxy; the mode http and httpclose options are unset in the haproxy conf file.
        /// </summary>
        public bool? KeepAliveEnabled {
            get { return GetParameterValue<bool?>(nameof(KeepAliveEnabled).ToLower()); }
            set { SetParameterValue(nameof(KeepAliveEnabled).ToLower(), value); }
        }

        /// <summary>
        /// maximum number of concurrent connections supported by the network offering
        /// </summary>
        public int? MaxConnections {
            get { return GetParameterValue<int?>(nameof(MaxConnections).ToLower()); }
            set { SetParameterValue(nameof(MaxConnections).ToLower(), value); }
        }

        /// <summary>
        /// data transfer rate in megabits per second allowed
        /// </summary>
        public int? NetworkRate {
            get { return GetParameterValue<int?>(nameof(NetworkRate).ToLower()); }
            set { SetParameterValue(nameof(NetworkRate).ToLower(), value); }
        }

        /// <summary>
        /// desired service capabilities as part of network offering
        /// </summary>
        public IList<IDictionary<string, object>> Servicecapabilitylist {
            get { return GetList<IDictionary<string, object>>(nameof(Servicecapabilitylist).ToLower()); }
            set { SetParameterValue(nameof(Servicecapabilitylist).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID used by virtual router provider
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IList<IDictionary<string, object>> ServiceProviderList {
            get { return GetList<IDictionary<string, object>>(nameof(ServiceProviderList).ToLower()); }
            set { SetParameterValue(nameof(ServiceProviderList).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports specifying ip ranges; defaulted to false if not specified
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return GetParameterValue<bool?>(nameof(SpecifyIpRanges).ToLower()); }
            set { SetParameterValue(nameof(SpecifyIpRanges).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports vlans
        /// </summary>
        public bool? SpecifyVlan {
            get { return GetParameterValue<bool?>(nameof(SpecifyVlan).ToLower()); }
            set { SetParameterValue(nameof(SpecifyVlan).ToLower(), value); }
        }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request);
        Task<NetworkOfferingResponse> CreateNetworkOfferingAsync(CreateNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request) => _proxy.Request<NetworkOfferingResponse>(request);
        public Task<NetworkOfferingResponse> CreateNetworkOfferingAsync(CreateNetworkOfferingRequest request) => _proxy.RequestAsync<NetworkOfferingResponse>(request);
    }
}
