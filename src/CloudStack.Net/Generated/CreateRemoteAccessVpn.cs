using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateRemoteAccessVpnRequest : APIRequest
    {
        public CreateRemoteAccessVpnRequest() : base("createRemoteAccessVpn") {}

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId {
            get { return GetParameterValue<Guid>(nameof(PublicIpId).ToLower()); }
            set { SetParameterValue(nameof(PublicIpId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the VPN. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the VPN. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the range of ip addresses to allocate to vpn clients. The first ip in the range will be taken by the vpn server
        /// </summary>
        public string IpRange {
            get { return GetParameterValue<string>(nameof(IpRange).ToLower()); }
            set { SetParameterValue(nameof(IpRange).ToLower(), value); }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitely. Has value true by default
        /// </summary>
        public bool? OpenFirewall {
            get { return GetParameterValue<bool?>(nameof(OpenFirewall).ToLower()); }
            set { SetParameterValue(nameof(OpenFirewall).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a l2tp/ipsec remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateRemoteAccessVpn(CreateRemoteAccessVpnRequest request);
        Task<AsyncJobResponse> CreateRemoteAccessVpnAsync(CreateRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateRemoteAccessVpn(CreateRemoteAccessVpnRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateRemoteAccessVpnAsync(CreateRemoteAccessVpnRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
