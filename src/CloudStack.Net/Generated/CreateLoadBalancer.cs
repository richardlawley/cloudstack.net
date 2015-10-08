using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLoadBalancerRequest : APIRequest
    {
        public CreateLoadBalancerRequest() : base("createLoadBalancer") {}

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// the TCP port of the virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int InstancePort { get; set; }

        /// <summary>
        /// name of the load balancer
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The guest network the load balancer will be created for
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// the load balancer scheme. Supported value in this release is Internal
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// the network id of the source ip address
        /// </summary>
        public Guid SourceIpNetworkId { get; set; }

        /// <summary>
        /// the source port the network traffic will be load balanced from
        /// </summary>
        public int SourcePort { get; set; }

        /// <summary>
        /// the description of the load balancer
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the source IP address the network traffic will be load balanced from
        /// </summary>
        public string SourceIp { get; set; }

    }
    /// <summary>
    /// Creates a load balancer
    /// </summary>
    /// <summary>
    /// Creates a load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApplicationLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApplicationLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request) => _proxy.Request<ApplicationLoadBalancerResponse>(request);
    }
}
