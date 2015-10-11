using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
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
    /// Dedicates a Pod.
    /// </summary>
    /// <summary>
    /// Dedicates a Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DedicatePod(DedicatePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DedicatePod(DedicatePodRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
