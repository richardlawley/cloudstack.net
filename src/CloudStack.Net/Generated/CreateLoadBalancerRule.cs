using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLoadBalancerRuleRequest : APIRequest
    {
        public CreateLoadBalancerRuleRequest() : base("createLoadBalancerRule") {}

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string LoadBalancerRuleName { get; set; }

        /// <summary>
        /// the private port of the private IP address/virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int PrivatePort { get; set; }

        /// <summary>
        /// the public port from where the network traffic will be load balanced from
        /// </summary>
        public int PublicPort { get; set; }

        /// <summary>
        /// the account associated with the load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist { get; set; }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain ID associated with the load balancer
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// The guest network this rule will be created for. Required when public Ip address is not associated with any Guest network yet (VPC case)
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// if true, firewall rule for source/end pubic port is automatically created; if false - firewall rule has to be created explicitely. If not specified 1) defaulted to false when LB rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall { get; set; }

        /// <summary>
        /// The protocol for the LB
        /// </summary>
        public string LbProtocol { get; set; }

        /// <summary>
        /// public IP address ID from where the network traffic will be load balanced from
        /// </summary>
        public Guid PublicIpId { get; set; }

        /// <summary>
        /// zone where the load balancer is going to be created. This parameter is required when LB service provider is ElasticLoadBalancerVm
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Creates a load balancer rule
    /// </summary>
    /// <summary>
    /// Creates a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoadBalancerResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoadBalancerResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request) => _proxy.Request<LoadBalancerResponse>(request);
    }
}
