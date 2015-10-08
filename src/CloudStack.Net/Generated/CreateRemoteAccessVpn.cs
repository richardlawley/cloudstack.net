using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateRemoteAccessVpnRequest : APIRequest
    {
        public CreateRemoteAccessVpnRequest() : base("createRemoteAccessVpn") {}

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId { get; set; }

        /// <summary>
        /// an optional account for the VPN. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional domainId for the VPN. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the range of ip addresses to allocate to vpn clients. The first ip in the range will be taken by the vpn server
        /// </summary>
        public string IpRange { get; set; }

        /// <summary>
        /// if true, firewall rule for source/end pubic port is automatically created; if false - firewall rule has to be created explicitely. Has value true by default
        /// </summary>
        public bool? OpenFirewall { get; set; }

    }
    /// <summary>
    /// Creates a l2tp/ipsec remote access vpn
    /// </summary>
    /// <summary>
    /// Creates a l2tp/ipsec remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RemoteAccessVpnResponse CreateRemoteAccessVpn(CreateRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RemoteAccessVpnResponse CreateRemoteAccessVpn(CreateRemoteAccessVpnRequest request) => _proxy.Request<RemoteAccessVpnResponse>(request);
    }
}
