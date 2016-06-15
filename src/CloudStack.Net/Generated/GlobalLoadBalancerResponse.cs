using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GlobalLoadBalancerResponse
    {
        /// <summary>
        /// global load balancer rule ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the load balancer rule
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the description of the global load balancer rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain of the load balancer rule
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the load balancer rule
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// DNS domain name given for the global load balancer
        /// </summary>
        public string GslbDomainName { get; set; }

        /// <summary>
        /// Load balancing method used for the global load balancer
        /// </summary>
        public string Gslblbmethod { get; set; }

        /// <summary>
        /// GSLB service type
        /// </summary>
        public string Gslbservicetype { get; set; }

        /// <summary>
        /// session persistence method used for the global load balancer
        /// </summary>
        public string Gslbstickysessionmethodname { get; set; }

        /// <summary>
        /// name of the global load balancer rule
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project name of the load balancer
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the load balancer
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Region Id in which global load balancer is created
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// List of load balancer rules that are part of GSLB rule
        /// </summary>
        public IList<LoadBalancerResponse> Loadbalancerrule { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
