using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVpnUsersRequest : APIRequest
    {
        public ListVpnUsersRequest() : base("listVpnUsers") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// The uuid of the Vpn user
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the username of the vpn user.
        /// </summary>
        public string UserName { get; set; }

    }
    /// <summary>
    /// Lists vpn users
    /// </summary>
    /// <summary>
    /// Lists vpn users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpnUsersResponse> ListVpnUsers(ListVpnUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpnUsersResponse> ListVpnUsers(ListVpnUsersRequest request) => _proxy.Request<ListResponse<VpnUsersResponse>>(request);
    }
}
