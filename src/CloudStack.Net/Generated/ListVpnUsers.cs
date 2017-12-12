using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVpnUsersRequest : APIListRequest
    {
        public ListVpnUsersRequest() : base("listVpnUsers") {}

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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// The uuid of the Vpn user
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the username of the vpn user.
        /// </summary>
        public string UserName {
            get { return GetParameterValue<string>(nameof(UserName).ToLower()); }
            set { SetParameterValue(nameof(UserName).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists vpn users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpnUsersResponse> ListVpnUsers(ListVpnUsersRequest request);
        Task<ListResponse<VpnUsersResponse>> ListVpnUsersAsync(ListVpnUsersRequest request);
        ListResponse<VpnUsersResponse> ListVpnUsersAllPages(ListVpnUsersRequest request);
        Task<ListResponse<VpnUsersResponse>> ListVpnUsersAllPagesAsync(ListVpnUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpnUsersResponse> ListVpnUsers(ListVpnUsersRequest request) => Proxy.Request<ListResponse<VpnUsersResponse>>(request);
        public Task<ListResponse<VpnUsersResponse>> ListVpnUsersAsync(ListVpnUsersRequest request) => Proxy.RequestAsync<ListResponse<VpnUsersResponse>>(request);
        public ListResponse<VpnUsersResponse> ListVpnUsersAllPages(ListVpnUsersRequest request) => Proxy.RequestAllPages<VpnUsersResponse>(request);
        public Task<ListResponse<VpnUsersResponse>> ListVpnUsersAllPagesAsync(ListVpnUsersRequest request) => Proxy.RequestAllPagesAsync<VpnUsersResponse>(request);
    }
}
