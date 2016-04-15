using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkRequest : APIRequest
    {
        public UpdateNetworkRequest() : base("updateNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force update even if CIDR type is different
        /// </summary>
        public bool? ChangeCidr {
            get { return GetParameterValue<bool?>(nameof(ChangeCidr).ToLower()); }
            set { SetParameterValue(nameof(ChangeCidr).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return GetParameterValue<bool?>(nameof(DisplayNetwork).ToLower()); }
            set { SetParameterValue(nameof(DisplayNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the new display text for the network
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// CIDR for guest VMs, CloudStack allocates IPs to guest VMs only from this CIDR
        /// </summary>
        public string GuestVmCidr {
            get { return GetParameterValue<string>(nameof(GuestVmCidr).ToLower()); }
            set { SetParameterValue(nameof(GuestVmCidr).ToLower(), value); }
        }

        /// <summary>
        /// the new name for the network
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// network offering ID
        /// </summary>
        public Guid NetworkOfferingId {
            get { return GetParameterValue<Guid>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request);
        Task<AsyncJobResponse> UpdateNetworkAsync(UpdateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateNetworkAsync(UpdateNetworkRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
