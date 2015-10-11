using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateClusterRequest : APIRequest
    {
        public DedicateClusterRequest() : base("dedicateCluster") {}

        /// <summary>
        /// the ID of the Cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Dedicate an existing cluster
    /// </summary>
    /// <summary>
    /// Dedicate an existing cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DedicateClusterResponse DedicateCluster(DedicateClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DedicateClusterResponse DedicateCluster(DedicateClusterRequest request) => _proxy.Request<DedicateClusterResponse>(request);
    }
}
