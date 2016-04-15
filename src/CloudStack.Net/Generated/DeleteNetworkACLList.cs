using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkACLListRequest : APIRequest
    {
        public DeleteNetworkACLListRequest() : base("deleteNetworkACLList") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a network ACL
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNetworkACLList(DeleteNetworkACLListRequest request);
        Task<AsyncJobResponse> DeleteNetworkACLListAsync(DeleteNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetworkACLList(DeleteNetworkACLListRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNetworkACLListAsync(DeleteNetworkACLListRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
