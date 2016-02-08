using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateZoneRequest : APIRequest
    {
        public UpdateZoneRequest() : base("updateZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// the details for the Zone
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// the dhcp Provider for the Zone
        /// </summary>
        public string DhcpProvider {
            get { return (string) Parameters[nameof(DhcpProvider).ToLower()]; }
            set { Parameters[nameof(DhcpProvider).ToLower()] = value; }
        }

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 {
            get { return (string) Parameters[nameof(Dns1).ToLower()]; }
            set { Parameters[nameof(Dns1).ToLower()] = value; }
        }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 {
            get { return (string) Parameters[nameof(Dns2).ToLower()]; }
            set { Parameters[nameof(Dns2).ToLower()] = value; }
        }

        /// <summary>
        /// the dns search order list
        /// </summary>
        public IList<string> DnsSearchOrder {
            get { return GetList<string>(nameof(DnsSearchOrder).ToLower()); }
            set { Parameters[nameof(DnsSearchOrder).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain name for the networks in the zone; empty string will update domain with NULL value
        /// </summary>
        public string Domain {
            get { return (string) Parameters[nameof(Domain).ToLower()]; }
            set { Parameters[nameof(Domain).ToLower()] = value; }
        }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress {
            get { return (string) Parameters[nameof(GuestCidrAddress).ToLower()]; }
            set { Parameters[nameof(GuestCidrAddress).ToLower()] = value; }
        }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 {
            get { return (string) Parameters[nameof(InternalDns1).ToLower()]; }
            set { Parameters[nameof(InternalDns1).ToLower()] = value; }
        }

        /// <summary>
        /// the second internal DNS for the Zone
        /// </summary>
        public string InternalDns2 {
            get { return (string) Parameters[nameof(InternalDns2).ToLower()]; }
            set { Parameters[nameof(InternalDns2).ToLower()] = value; }
        }

        /// <summary>
        /// the first DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns1 {
            get { return (string) Parameters[nameof(Ip6Dns1).ToLower()]; }
            set { Parameters[nameof(Ip6Dns1).ToLower()] = value; }
        }

        /// <summary>
        /// the second DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns2 {
            get { return (string) Parameters[nameof(Ip6Dns2).ToLower()]; }
            set { Parameters[nameof(Ip6Dns2).ToLower()] = value; }
        }

        /// <summary>
        /// updates a private zone to public if set, but not vice-versa
        /// </summary>
        public bool? IsPublic {
            get { return (bool?) Parameters[nameof(IsPublic).ToLower()]; }
            set { Parameters[nameof(IsPublic).ToLower()] = value; }
        }

        /// <summary>
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled {
            get { return (bool?) Parameters[nameof(LocalStorageEnabled).ToLower()]; }
            set { Parameters[nameof(LocalStorageEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ZoneResponse UpdateZone(UpdateZoneRequest request);
        Task<ZoneResponse> UpdateZoneAsync(UpdateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ZoneResponse UpdateZone(UpdateZoneRequest request) => _proxy.Request<ZoneResponse>(request);
        public Task<ZoneResponse> UpdateZoneAsync(UpdateZoneRequest request) => _proxy.RequestAsync<ZoneResponse>(request);
    }
}
