using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateGlobalLoadBalancerRuleRequest : APIRequest
    {
        public CreateGlobalLoadBalancerRuleRequest() : base("createGlobalLoadBalancerRule") {}

        /// <summary>
        /// domain name for the GSLB service.
        /// </summary>
        public string ServiceDomainName { get; set; }

        /// <summary>
        /// GSLB service type (tcp, udp, http)
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string GlobalLoadBalancerRuleName { get; set; }

        /// <summary>
        /// region where the global load balancer is going to be created.
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// the account associated with the global load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain ID associated with the load balancer
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// load balancer algorithm (roundrobin, leastconn, proximity) that method is used to distribute traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string StickyMethod { get; set; }

    }
    /// <summary>
    /// Creates a global load balancer rule
    /// </summary>
    /// <summary>
    /// Creates a global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GlobalLoadBalancerResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GlobalLoadBalancerResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request) => _proxy.Request<GlobalLoadBalancerResponse>(request);
    }
}
