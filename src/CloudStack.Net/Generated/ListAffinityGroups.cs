using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAffinityGroupsRequest : APIRequest
    {
        public ListAffinityGroupsRequest() : base("listAffinityGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list the affinity group by the ID provided
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
        /// lists affinity groups by name
        /// </summary>
        public string AffinityGroupName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// lists affinity groups by type
        /// </summary>
        public string AffinityGroupType { get; set; }

        /// <summary>
        /// lists affinity groups by virtual machine ID
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Lists affinity groups
    /// </summary>
    /// <summary>
    /// Lists affinity groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AffinityGroupResponse> ListAffinityGroups(ListAffinityGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AffinityGroupResponse> ListAffinityGroups(ListAffinityGroupsRequest request) => _proxy.Request<ListResponse<AffinityGroupResponse>>(request);
    }
}
