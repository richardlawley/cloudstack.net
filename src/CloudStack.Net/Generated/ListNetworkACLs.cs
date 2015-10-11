using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkACLsRequest : APIRequest
    {
        public ListNetworkACLsRequest() : base("listNetworkACLs") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list network ACL Items by ACL Id
        /// </summary>
        public Guid AclId {
            get { return (Guid) Parameters[nameof(AclId).ToLower()]; }
            set { Parameters[nameof(AclId).ToLower()] = value; }
        }

        /// <summary>
        /// list network ACL Items by Action
        /// </summary>
        public string Action {
            get { return (string) Parameters[nameof(Action).ToLower()]; }
            set { Parameters[nameof(Action).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// Lists network ACL Item with the specified ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// list network ACL Items by network Id
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// list network ACL Items by Protocol
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// list network ACL Items by traffic type - Ingress or Egress
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all network ACL items
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkACLItemResponse> ListNetworkACLs(ListNetworkACLsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkACLItemResponse> ListNetworkACLs(ListNetworkACLsRequest request) => _proxy.Request<ListResponse<NetworkACLItemResponse>>(request);
    }
}
