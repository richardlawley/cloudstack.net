using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SecurityGroupRuleResponse
    {
        /// <summary>
        /// account owning the security group rule
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the CIDR notation for the base IP address of the security group rule
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the ending IP of the security group rule 
        /// </summary>
        public int EndPort { get; set; }

        /// <summary>
        /// the code for the ICMP message response
        /// </summary>
        public int IcmpCode { get; set; }

        /// <summary>
        /// the type of the ICMP message response
        /// </summary>
        public int IcmpType { get; set; }

        /// <summary>
        /// the protocol of the security group rule
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the id of the security group rule
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// security group name
        /// </summary>
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// the starting IP of the security group rule
        /// </summary>
        public int StartPort { get; set; }

        /// <summary>
        /// the list of resource tags associated with the rule
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
