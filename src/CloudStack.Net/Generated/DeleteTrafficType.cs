using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTrafficTypeRequest : APIRequest
    {
        public DeleteTrafficTypeRequest() : base("deleteTrafficType") {}

        /// <summary>
        /// traffic type id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes traffic type of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTrafficType(DeleteTrafficTypeRequest request);
        Task<AsyncJobResponse> DeleteTrafficTypeAsync(DeleteTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTrafficType(DeleteTrafficTypeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTrafficTypeAsync(DeleteTrafficTypeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
