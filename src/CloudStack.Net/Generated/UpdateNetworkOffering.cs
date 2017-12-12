using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Availability).ToLower()); }
            set { SetParameterValue(nameof(Availability).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the network offering
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the id of the network offering
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        /// the name of the network offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the network offering, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

        /// <summary>
        /// update state for the network offering
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkOfferingResponse UpdateNetworkOffering(UpdateNetworkOfferingRequest request);
        Task<NetworkOfferingResponse> UpdateNetworkOfferingAsync(UpdateNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkOfferingResponse UpdateNetworkOffering(UpdateNetworkOfferingRequest request) => Proxy.Request<NetworkOfferingResponse>(request);
        public Task<NetworkOfferingResponse> UpdateNetworkOfferingAsync(UpdateNetworkOfferingRequest request) => Proxy.RequestAsync<NetworkOfferingResponse>(request);
    }
}
