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
        /// Lists resource limits by ID.
        /// </summary>
        public long? Id {
            get { return (long?) Parameters[nameof(Id).ToLower()]; }
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
        /// Type of resource to update. Values are 0, 1, 2, 3, and 4.0 - Instance. Number of instances a user can create. 1 - IP. Number of public IP addresses an account can own. 2 - Volume. Number of disk volumes an account can own.3 - Snapshot. Number of snapshots an account can own.4 - Template. Number of templates an account can register/create.5 - Project. Number of projects an account can own.6 - Network. Number of networks an account can own.7 - VPC. Number of VPC an account can own.8 - CPU. Number of CPU an account can allocate for his resources.9 - Memory. Amount of RAM an account can allocate for his resources.10 - Primary Storage. Amount of Primary storage an account can allocate for his resoruces.11 - Secondary Storage. Amount of Secondary storage an account can allocate for his resources.
        /// </summary>
        public int? ResourceType {
            get { return (int?) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

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
