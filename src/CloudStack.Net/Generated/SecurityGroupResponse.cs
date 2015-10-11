using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SecurityGroupResponse
    {
        /// <summary>
        /// the ID of the security group
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the security group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the description of the security group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain name of the security group
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the security group
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the name of the security group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project name of the group
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the group
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the list of egress rules associated with the security group
        /// </summary>
        public IList<SecurityGroupRuleResponse> Egressrule { get; set; }

        /// <summary>
        /// the list of ingress rules associated with the security group
        /// </summary>
        public IList<SecurityGroupRuleResponse> Ingressrule { get; set; }

        /// <summary>
        /// the list of resource tags associated with the rule
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        /// <summary>
        /// the ID of the latest async job acting on this object
        /// </summary>
        public Guid jobid { get; set; }

        /// <summary>
        /// the current status of the latest async job acting on this object
        /// </summary>
        public string jobstatus { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
