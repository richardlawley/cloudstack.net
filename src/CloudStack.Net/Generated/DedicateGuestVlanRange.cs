using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// physical network ID of the vlan
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// guest vlan range to be dedicated
        /// </summary>
        public string Vlanrange {
            get { return GetParameterValue<string>(nameof(Vlanrange).ToLower()); }
            set { SetParameterValue(nameof(Vlanrange).ToLower(), value); }
        }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Dedicates a guest vlan range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request);
        Task<GuestVlanRangeResponse> DedicateGuestVlanRangeAsync(DedicateGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request) => Proxy.Request<GuestVlanRangeResponse>(request);
        public Task<GuestVlanRangeResponse> DedicateGuestVlanRangeAsync(DedicateGuestVlanRangeRequest request) => Proxy.RequestAsync<GuestVlanRangeResponse>(request);
    }
}
