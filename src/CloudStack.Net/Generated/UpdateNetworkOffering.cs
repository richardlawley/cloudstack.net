using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkOfferingRequest : APIRequest
    {
        public UpdateNetworkOfferingRequest() : base("updateNetworkOffering") {}

        /// <summary>
        /// the availability of network offering. Default value is Required for Guest Virtual network offering; Optional for Guest Direct network offering
        /// </summary>
        public string Availability {
            get { return (string) Parameters[nameof(Availability).ToLower()]; }
            set { Parameters[nameof(Availability).ToLower()] = value; }
        }

        /// <summary>
        /// the display text of the network offering
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the id of the network offering
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
        /// the name of the network offering
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// sort key of the network offering, integer
        /// </summary>
        public int? SortKey {
            get { return (int?) Parameters[nameof(SortKey).ToLower()]; }
            set { Parameters[nameof(SortKey).ToLower()] = value; }
        }

        /// <summary>
        /// update state for the network offering
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkOfferingResponse UpdateNetworkOffering(UpdateNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkOfferingResponse UpdateNetworkOffering(UpdateNetworkOfferingRequest request) => _proxy.Request<NetworkOfferingResponse>(request);
    }
}
