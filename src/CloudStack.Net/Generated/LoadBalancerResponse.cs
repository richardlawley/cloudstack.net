using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LoadBalancerResponse
    {
        /// <summary>
        /// the load balancer rule ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the load balancer rule
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public string CidrList { get; set; }

        /// <summary>
        /// the description of the load balancer
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
        /// is rule for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the name of the load balancer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the id of the guest network the lb rule belongs to
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the private port
        /// </summary>
        public string PrivatePort { get; set; }

        /// <summary>
        /// the project name of the load balancer
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the load balancer
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the protocol of the loadbalanacer rule
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the public ip address
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// the public ip address id
        /// </summary>
        public string PublicIpId { get; set; }

        /// <summary>
        /// the public port
        /// </summary>
        public string PublicPort { get; set; }

        /// <summary>
        /// the state of the rule
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the id of the zone the rule belongs to
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the list of resource tags associated with load balancer
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
