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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// the details for the Zone
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the dhcp Provider for the Zone
        /// </summary>
        public string DhcpProvider {
            get { return GetParameterValue<string>(nameof(DhcpProvider).ToLower()); }
            set { SetParameterValue(nameof(DhcpProvider).ToLower(), value); }
        }

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 {
            get { return GetParameterValue<string>(nameof(Dns1).ToLower()); }
            set { SetParameterValue(nameof(Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 {
            get { return GetParameterValue<string>(nameof(Dns2).ToLower()); }
            set { SetParameterValue(nameof(Dns2).ToLower(), value); }
        }

        /// <summary>
        /// the dns search order list
        /// </summary>
        public IList<string> DnsSearchOrder {
            get { return GetList<string>(nameof(DnsSearchOrder).ToLower()); }
            set { SetParameterValue(nameof(DnsSearchOrder).ToLower(), value); }
        }

        /// <summary>
        /// Network domain name for the networks in the zone; empty string will update domain with NULL value
        /// </summary>
        public string Domain {
            get { return GetParameterValue<string>(nameof(Domain).ToLower()); }
            set { SetParameterValue(nameof(Domain).ToLower(), value); }
        }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress {
            get { return GetParameterValue<string>(nameof(GuestCidrAddress).ToLower()); }
            set { SetParameterValue(nameof(GuestCidrAddress).ToLower(), value); }
        }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 {
            get { return GetParameterValue<string>(nameof(InternalDns1).ToLower()); }
            set { SetParameterValue(nameof(InternalDns1).ToLower(), value); }
        }

        /// <summary>
        /// the second internal DNS for the Zone
        /// </summary>
        public string InternalDns2 {
            get { return GetParameterValue<string>(nameof(InternalDns2).ToLower()); }
            set { SetParameterValue(nameof(InternalDns2).ToLower(), value); }
        }

        /// <summary>
        /// the first DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns1 {
            get { return GetParameterValue<string>(nameof(Ip6Dns1).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns2 {
            get { return GetParameterValue<string>(nameof(Ip6Dns2).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns2).ToLower(), value); }
        }

        /// <summary>
        /// updates a private zone to public if set, but not vice-versa
        /// </summary>
        public bool? IsPublic {
            get { return GetParameterValue<bool?>(nameof(IsPublic).ToLower()); }
            set { SetParameterValue(nameof(IsPublic).ToLower(), value); }
        }

        /// <summary>
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled {
            get { return GetParameterValue<bool?>(nameof(LocalStorageEnabled).ToLower()); }
            set { SetParameterValue(nameof(LocalStorageEnabled).ToLower(), value); }
        }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
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
        public ZoneResponse UpdateZone(UpdateZoneRequest request) => Proxy.Request<ZoneResponse>(request);
        public Task<ZoneResponse> UpdateZoneAsync(UpdateZoneRequest request) => Proxy.RequestAsync<ZoneResponse>(request);
    }
}
