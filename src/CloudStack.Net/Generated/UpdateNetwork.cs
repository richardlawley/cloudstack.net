using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force update even if cidr type is different
        /// </summary>
        public bool? ChangeCidr {
            get { return (bool?) Parameters[nameof(ChangeCidr).ToLower()]; }
            set { Parameters[nameof(ChangeCidr).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return (bool?) Parameters[nameof(DisplayNetwork).ToLower()]; }
            set { Parameters[nameof(DisplayNetwork).ToLower()] = value; }
        }

        /// <summary>
        /// the new display text for the network
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// CIDR for Guest VMs,Cloudstack allocates IPs to Guest VMs only from this CIDR
        /// </summary>
        public string GuestVmCidr {
            get { return (string) Parameters[nameof(GuestVmCidr).ToLower()]; }
            set { Parameters[nameof(GuestVmCidr).ToLower()] = value; }
        }

        /// <summary>
        /// the new name for the network
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

        /// <summary>
        /// network offering ID
        /// </summary>
        public Guid NetworkOfferingId {
            get { return (Guid) Parameters[nameof(NetworkOfferingId).ToLower()]; }
            set { Parameters[nameof(NetworkOfferingId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a network
    /// </summary>
    /// <summary>
    /// Updates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
