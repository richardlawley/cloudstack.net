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
        public string Availability { get; set; }

        /// <summary>
        /// the display text of the network offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the id of the network offering
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// if true keepalive will be turned on in the loadbalancer. At the time of writing this has only an effect on haproxy; the mode http and httpclose options are unset in the haproxy conf file.
        /// </summary>
        public bool? KeepAliveEnabled { get; set; }

        /// <summary>
        /// maximum number of concurrent connections supported by the network offering
        /// </summary>
        public int? MaxConnections { get; set; }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string NetworkOfferingName { get; set; }

        /// <summary>
        /// sort key of the network offering, integer
        /// </summary>
        public int? SortKey { get; set; }

        /// <summary>
        /// update state for the network offering
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Updates a network offering.
    /// </summary>
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
