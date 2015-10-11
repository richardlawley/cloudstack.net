using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateResourceCountRequest : APIRequest
    {
        public UpdateResourceCountRequest() : base("updateResourceCount") {}

        /// <summary>
        /// If account parameter specified then updates resource counts for a specified account in this domain else update resource counts for all accounts & child domains in specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Update resource count for a specified account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Update resource limits for project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// Type of resource to update. If specifies valid values are 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 and 11. If not specified will update all resource counts0 - Instance. Number of instances a user can create. 1 - IP. Number of public IP addresses a user can own. 2 - Volume. Number of disk volumes a user can create.3 - Snapshot. Number of snapshots a user can create.4 - Template. Number of templates that a user can register/create.5 - Project. Number of projects that a user can create.6 - Network. Number of guest network a user can create.7 - VPC. Number of VPC a user can create.8 - CPU. Total number of CPU cores a user can use.9 - Memory. Total Memory (in MB) a user can use.10 - PrimaryStorage. Total primary storage space (in GiB) a user can use.11 - SecondaryStorage. Total secondary storage space (in GiB) a user can use.
        /// </summary>
        public int? ResourceType {
            get { return (int?) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Recalculate and update resource count for an account or domain.
    /// </summary>
    /// <summary>
    /// Recalculate and update resource count for an account or domain.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ResourceCountResponse UpdateResourceCount(UpdateResourceCountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ResourceCountResponse UpdateResourceCount(UpdateResourceCountRequest request) => _proxy.Request<ResourceCountResponse>(request);
    }
}
