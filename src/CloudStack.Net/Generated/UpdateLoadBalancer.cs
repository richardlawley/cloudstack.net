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
        /// the ID of the load balancer
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates a load balancer
    /// </summary>
    /// <summary>
    /// Updates a load balancer
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
