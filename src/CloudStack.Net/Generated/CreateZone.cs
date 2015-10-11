using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Dns1).ToLower()]; }
            set { Parameters[nameof(Dns1).ToLower()] = value; }
        }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 {
            get { return (string) Parameters[nameof(InternalDns1).ToLower()]; }
            set { Parameters[nameof(InternalDns1).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// network type of the zone, can be Basic or Advanced
        /// </summary>
        public string NetworkType {
            get { return (string) Parameters[nameof(NetworkType).ToLower()]; }
            set { Parameters[nameof(NetworkType).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this Zone for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 {
            get { return (string) Parameters[nameof(Dns2).ToLower()]; }
            set { Parameters[nameof(Dns2).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain name for the networks in the zone
        /// </summary>
        public string Domain {
            get { return (string) Parameters[nameof(Domain).ToLower()]; }
            set { Parameters[nameof(Domain).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the containing domain, null for public zones
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress {
            get { return (string) Parameters[nameof(GuestCidrAddress).ToLower()]; }
            set { Parameters[nameof(GuestCidrAddress).ToLower()] = value; }
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
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled {
            get { return (bool?) Parameters[nameof(LocalStorageEnabled).ToLower()]; }
            set { Parameters[nameof(LocalStorageEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// true if network is security group enabled, false otherwise
        /// </summary>
        public bool? Securitygroupenabled {
            get { return (bool?) Parameters[nameof(Securitygroupenabled).ToLower()]; }
            set { Parameters[nameof(Securitygroupenabled).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ZoneResponse CreateZone(CreateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ZoneResponse CreateZone(CreateZoneRequest request) => _proxy.Request<ZoneResponse>(request);
    }
}
