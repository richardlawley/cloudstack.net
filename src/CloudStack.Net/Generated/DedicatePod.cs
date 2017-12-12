using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicatePodRequest : APIRequest
    {
        public DedicatePodRequest() : base("dedicatePod") {}

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
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
    /// Dedicates a Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DedicatePod(DedicatePodRequest request);
        Task<AsyncJobResponse> DedicatePodAsync(DedicatePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DedicatePod(DedicatePodRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DedicatePodAsync(DedicatePodRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
