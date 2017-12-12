using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateZoneRequest : APIRequest
    {
        public CreateZoneRequest() : base("createZone") {}

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 {
            get { return GetParameterValue<string>(nameof(Dns1).ToLower()); }
            set { SetParameterValue(nameof(Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 {
            get { return GetParameterValue<string>(nameof(InternalDns1).ToLower()); }
            set { SetParameterValue(nameof(InternalDns1).ToLower(), value); }
        }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// network type of the zone, can be Basic or Advanced
        /// </summary>
        public string NetworkType {
            get { return GetParameterValue<string>(nameof(NetworkType).ToLower()); }
            set { SetParameterValue(nameof(NetworkType).ToLower(), value); }
        }

        /// <summary>
        /// Allocation state of this Zone for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 {
            get { return GetParameterValue<string>(nameof(Dns2).ToLower()); }
            set { SetParameterValue(nameof(Dns2).ToLower(), value); }
        }

        /// <summary>
        /// Network domain name for the networks in the zone
        /// </summary>
        public string Domain {
            get { return GetParameterValue<string>(nameof(Domain).ToLower()); }
            set { SetParameterValue(nameof(Domain).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain, null for public zones
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress {
            get { return GetParameterValue<string>(nameof(GuestCidrAddress).ToLower()); }
            set { SetParameterValue(nameof(GuestCidrAddress).ToLower(), value); }
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
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled {
            get { return GetParameterValue<bool?>(nameof(LocalStorageEnabled).ToLower()); }
            set { SetParameterValue(nameof(LocalStorageEnabled).ToLower(), value); }
        }

        /// <summary>
        /// true if network is security group enabled, false otherwise
        /// </summary>
        public bool? Securitygroupenabled {
            get { return GetParameterValue<bool?>(nameof(Securitygroupenabled).ToLower()); }
            set { SetParameterValue(nameof(Securitygroupenabled).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ZoneResponse CreateZone(CreateZoneRequest request);
        Task<ZoneResponse> CreateZoneAsync(CreateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ZoneResponse CreateZone(CreateZoneRequest request) => Proxy.Request<ZoneResponse>(request);
        public Task<ZoneResponse> CreateZoneAsync(CreateZoneRequest request) => Proxy.RequestAsync<ZoneResponse>(request);
    }
}
