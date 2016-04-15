using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListResourceLimitsRequest : APIListRequest
    {
        public ListResourceLimitsRequest() : base("listResourceLimits") {}

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
        /// Lists resource limits by ID.
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
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
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Type of resource. Values are 0, 1, 2, 3, 4, 6, 7, 8, 9, 10 and 11. 0 - Instance. Number of instances a user can create. 1 - IP. Number of public IP addresses an account can own. 2 - Volume. Number of disk volumes an account can own. 3 - Snapshot. Number of snapshots an account can own. 4 - Template. Number of templates an account can register/create. 5 - Project. Number of projects an account can own. 6 - Network. Number of networks an account can own. 7 - VPC. Number of VPC an account can own. 8 - CPU. Number of CPU an account can allocate for his resources. 9 - Memory. Amount of RAM an account can allocate for his resources. 10 - PrimaryStorage. Total primary storage space (in GiB) a user can use. 11 - SecondaryStorage. Total secondary storage space (in GiB) a user can use. 
        /// </summary>
        public int? ResourceType {
            get { return GetParameterValue<int?>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists resource limits.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ResourceLimitResponse> ListResourceLimits(ListResourceLimitsRequest request);
        Task<ListResponse<ResourceLimitResponse>> ListResourceLimitsAsync(ListResourceLimitsRequest request);
        ListResponse<ResourceLimitResponse> ListResourceLimitsAllPages(ListResourceLimitsRequest request);
        Task<ListResponse<ResourceLimitResponse>> ListResourceLimitsAllPagesAsync(ListResourceLimitsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ResourceLimitResponse> ListResourceLimits(ListResourceLimitsRequest request) => _proxy.Request<ListResponse<ResourceLimitResponse>>(request);
        public Task<ListResponse<ResourceLimitResponse>> ListResourceLimitsAsync(ListResourceLimitsRequest request) => _proxy.RequestAsync<ListResponse<ResourceLimitResponse>>(request);
        public ListResponse<ResourceLimitResponse> ListResourceLimitsAllPages(ListResourceLimitsRequest request) => _proxy.RequestAllPages<ResourceLimitResponse>(request);
        public Task<ListResponse<ResourceLimitResponse>> ListResourceLimitsAllPagesAsync(ListResourceLimitsRequest request) => _proxy.RequestAllPagesAsync<ResourceLimitResponse>(request);
    }
}
