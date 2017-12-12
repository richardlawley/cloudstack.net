using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkACLRequest : APIRequest
    {
        public DeleteNetworkACLRequest() : base("deleteNetworkACL") {}

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
        AsyncJobResponse DeleteNetworkACL(DeleteNetworkACLRequest request);
        Task<AsyncJobResponse> DeleteNetworkACLAsync(DeleteNetworkACLRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetworkACL(DeleteNetworkACLRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNetworkACLAsync(DeleteNetworkACLRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
