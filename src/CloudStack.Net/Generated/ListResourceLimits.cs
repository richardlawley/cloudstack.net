using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListResourceLimitsRequest : APIRequest
    {
        public ListResourceLimitsRequest() : base("listResourceLimits") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Lists resource limits by ID.
        /// </summary>
        public long? Id { get; set; }

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
        /// Type of resource. Values are 0, 1, 2, 3, 4, 6, 7, 8, 9, 10 and 11. 0 - Instance. Number of instances a user can create. 1 - IP. Number of public IP addresses an account can own. 2 - Volume. Number of disk volumes an account can own. 3 - Snapshot. Number of snapshots an account can own. 4 - Template. Number of templates an account can register/create. 5 - Project. Number of projects an account can own. 6 - Network. Number of networks an account can own. 7 - VPC. Number of VPC an account can own. 8 - CPU. Number of CPU an account can allocate for his resources. 9 - Memory. Amount of RAM an account can allocate for his resources. 10 - PrimaryStorage. Total primary storage space (in GiB) a user can use. 11 - SecondaryStorage. Total secondary storage space (in GiB) a user can use. 
        /// </summary>
        public int? ResourceType { get; set; }

    }
    /// <summary>
    /// Lists resource limits.
    /// </summary>
    /// <summary>
    /// Lists resource limits.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ResourceLimitResponse> ListResourceLimits(ListResourceLimitsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ResourceLimitResponse> ListResourceLimits(ListResourceLimitsRequest request) => _proxy.Request<ListResponse<ResourceLimitResponse>>(request);
    }
}
