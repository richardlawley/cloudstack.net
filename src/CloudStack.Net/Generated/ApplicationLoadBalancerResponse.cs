using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApplicationLoadBalancerResponse
    {
        /// <summary>
        /// the Load Balancer ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the Load Balancer
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// the description of the Load Balancer
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain of the Load Balancer
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the Load Balancer
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is rule for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the name of the Load Balancer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Load Balancer network id
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the project name of the Load Balancer
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the Load Balancer
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Load Balancer source ip
        /// </summary>
        public string Sourceipaddress { get; set; }

        /// <summary>
        /// Load Balancer source ip network id
        /// </summary>
        public string Sourceipaddressnetworkid { get; set; }

        /// <summary>
        /// the list of instances associated with the Load Balancer
        /// </summary>
        public IList<ApplicationLoadBalancerInstanceResponse> Loadbalancerinstance { get; set; }

        /// <summary>
        /// the list of rules associated with the Load Balancer
        /// </summary>
        public IList<ApplicationLoadBalancerRuleResponse> Loadbalancerrule { get; set; }

        /// <summary>
        /// the list of resource tags associated with the Load Balancer
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
