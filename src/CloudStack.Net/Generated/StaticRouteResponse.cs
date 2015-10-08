using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StaticRouteResponse
    {
        /// <summary>
        /// the ID of static route
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the static route
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// static route CIDR
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the domain associated with the static route
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the static route
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// VPC gateway the route is created for
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// the project name of the static route
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the static route
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the state of the static route
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// VPC the static route belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// the list of resource tags associated with static route
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
