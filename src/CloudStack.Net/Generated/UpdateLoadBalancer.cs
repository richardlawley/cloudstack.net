using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLoadBalancerRequest : APIRequest
    {
        public UpdateLoadBalancerRequest() : base("updateLoadBalancer") {}

        /// <summary>
        /// the ID of the Load Balancer
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a Load Balancer
    /// </summary>
    /// <summary>
    /// Updates a Load Balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApplicationLoadBalancerResponse UpdateLoadBalancer(UpdateLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApplicationLoadBalancerResponse UpdateLoadBalancer(UpdateLoadBalancerRequest request) => _proxy.Request<ApplicationLoadBalancerResponse>(request);
    }
}
