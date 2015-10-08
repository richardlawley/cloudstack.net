using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSecurityGroupsRequest : APIRequest
    {
        public ListSecurityGroupsRequest() : base("listSecurityGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list the security group by the id provided
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
        /// lists security groups by name
        /// </summary>
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// lists security groups by virtual machine id
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Lists security groups
    /// </summary>
    /// <summary>
    /// Lists security groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SecurityGroupResponse> ListSecurityGroups(ListSecurityGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SecurityGroupResponse> ListSecurityGroups(ListSecurityGroupsRequest request) => _proxy.Request<ListResponse<SecurityGroupResponse>>(request);
    }
}
