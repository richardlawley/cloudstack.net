using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSecurityGroupsRequest : APIListRequest
    {
        public ListSecurityGroupsRequest() : base("listSecurityGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list the security group by the id provided
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
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// lists security groups by name
        /// </summary>
        public string SecurityGroupName {
            get { return (string) Parameters[nameof(SecurityGroupName).ToLower()]; }
            set { Parameters[nameof(SecurityGroupName).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// lists security groups by virtual machine id
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists security groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SecurityGroupResponse> ListSecurityGroups(ListSecurityGroupsRequest request);
        Task<ListResponse<SecurityGroupResponse>> ListSecurityGroupsAsync(ListSecurityGroupsRequest request);
        ListResponse<SecurityGroupResponse> ListSecurityGroupsAllPages(ListSecurityGroupsRequest request);
        Task<ListResponse<SecurityGroupResponse>> ListSecurityGroupsAllPagesAsync(ListSecurityGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SecurityGroupResponse> ListSecurityGroups(ListSecurityGroupsRequest request) => _proxy.Request<ListResponse<SecurityGroupResponse>>(request);
        public Task<ListResponse<SecurityGroupResponse>> ListSecurityGroupsAsync(ListSecurityGroupsRequest request) => _proxy.RequestAsync<ListResponse<SecurityGroupResponse>>(request);
        public ListResponse<SecurityGroupResponse> ListSecurityGroupsAllPages(ListSecurityGroupsRequest request) => _proxy.RequestAllPages<SecurityGroupResponse>(request);
        public Task<ListResponse<SecurityGroupResponse>> ListSecurityGroupsAllPagesAsync(ListSecurityGroupsRequest request) => _proxy.RequestAllPagesAsync<SecurityGroupResponse>(request);
    }
}
