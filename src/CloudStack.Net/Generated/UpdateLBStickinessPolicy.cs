using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLBStickinessPolicyRequest : APIRequest
    {
        public UpdateLBStickinessPolicyRequest() : base("updateLBStickinessPolicy") {}

        /// <summary>
        /// id of lb stickiness policy
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
    /// Updates load balancer stickiness policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateLBStickinessPolicy(UpdateLBStickinessPolicyRequest request);
        Task<AsyncJobResponse> UpdateLBStickinessPolicyAsync(UpdateLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateLBStickinessPolicy(UpdateLBStickinessPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateLBStickinessPolicyAsync(UpdateLBStickinessPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
