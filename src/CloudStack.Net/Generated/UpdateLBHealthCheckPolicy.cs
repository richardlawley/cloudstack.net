using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLBHealthCheckPolicyRequest : APIRequest
    {
        public UpdateLBHealthCheckPolicyRequest() : base("updateLBHealthCheckPolicy") {}

        /// <summary>
        /// ID of load balancer health check policy
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the policy to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates load balancer health check policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateLBHealthCheckPolicy(UpdateLBHealthCheckPolicyRequest request);
        Task<AsyncJobResponse> UpdateLBHealthCheckPolicyAsync(UpdateLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateLBHealthCheckPolicy(UpdateLBHealthCheckPolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateLBHealthCheckPolicyAsync(UpdateLBHealthCheckPolicyRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
