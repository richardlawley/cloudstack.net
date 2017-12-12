using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteClusterRequest : APIRequest
    {
        public DeleteClusterRequest() : base("deleteCluster") {}

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a cluster.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCluster(DeleteClusterRequest request);
        Task<SuccessResponse> DeleteClusterAsync(DeleteClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCluster(DeleteClusterRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteClusterAsync(DeleteClusterRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
