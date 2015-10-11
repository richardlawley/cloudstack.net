using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateGuestVlanRangeRequest : APIRequest
    {
        public DedicateGuestVlanRangeRequest() : base("dedicateGuestVlanRange") {}

        /// <summary>
        /// account who will own the VLAN
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// physical network ID of the vlan
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// guest vlan range to be dedicated
        /// </summary>
        public string Vlanrange {
            get { return (string) Parameters[nameof(Vlanrange).ToLower()]; }
            set { Parameters[nameof(Vlanrange).ToLower()] = value; }
        }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Dedicates a guest vlan range to an account
    /// </summary>
    /// <summary>
    /// Dedicates a guest vlan range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request) => _proxy.Request<GuestVlanRangeResponse>(request);
    }
}
