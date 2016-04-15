using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRemoteAccessVpnsRequest : APIListRequest
    {
        public ListRemoteAccessVpnsRequest() : base("listRemoteAccessVpns") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// Lists remote access vpn rule with the specified ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list remote access VPNs for ceratin network
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId {
            get { return GetParameterValue<Guid>(nameof(PublicIpId).ToLower()); }
            set { SetParameterValue(nameof(PublicIpId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists remote access vpns
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpns(ListRemoteAccessVpnsRequest request);
        Task<ListResponse<RemoteAccessVpnResponse>> ListRemoteAccessVpnsAsync(ListRemoteAccessVpnsRequest request);
        ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpnsAllPages(ListRemoteAccessVpnsRequest request);
        Task<ListResponse<RemoteAccessVpnResponse>> ListRemoteAccessVpnsAllPagesAsync(ListRemoteAccessVpnsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpns(ListRemoteAccessVpnsRequest request) => _proxy.Request<ListResponse<RemoteAccessVpnResponse>>(request);
        public Task<ListResponse<RemoteAccessVpnResponse>> ListRemoteAccessVpnsAsync(ListRemoteAccessVpnsRequest request) => _proxy.RequestAsync<ListResponse<RemoteAccessVpnResponse>>(request);
        public ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpnsAllPages(ListRemoteAccessVpnsRequest request) => _proxy.RequestAllPages<RemoteAccessVpnResponse>(request);
        public Task<ListResponse<RemoteAccessVpnResponse>> ListRemoteAccessVpnsAllPagesAsync(ListRemoteAccessVpnsRequest request) => _proxy.RequestAllPagesAsync<RemoteAccessVpnResponse>(request);
    }
}
