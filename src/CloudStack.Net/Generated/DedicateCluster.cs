using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

    }
    /// <summary>
    /// Dedicate an existing cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DedicateCluster(DedicateClusterRequest request);
        Task<AsyncJobResponse> DedicateClusterAsync(DedicateClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DedicateCluster(DedicateClusterRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DedicateClusterAsync(DedicateClusterRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
