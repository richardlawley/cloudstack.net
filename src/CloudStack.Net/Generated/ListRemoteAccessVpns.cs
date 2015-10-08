using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRemoteAccessVpnsRequest : APIRequest
    {
        public ListRemoteAccessVpnsRequest() : base("listRemoteAccessVpns") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Lists remote access vpn rule with the specified ID
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

        /// <summary>
        /// list remote access VPNs for ceratin network
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId { get; set; }

    }
    /// <summary>
    /// Lists remote access vpns
    /// </summary>
    /// <summary>
    /// Lists remote access vpns
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpns(ListRemoteAccessVpnsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RemoteAccessVpnResponse> ListRemoteAccessVpns(ListRemoteAccessVpnsRequest request) => _proxy.Request<ListResponse<RemoteAccessVpnResponse>>(request);
    }
}
