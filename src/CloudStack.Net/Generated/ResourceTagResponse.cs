using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResourceTagResponse
    {
        /// <summary>
        /// the account associated with the tag
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// customer associated with the tag
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// the domain associated with the tag
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the tag
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// tag key name
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// the project name where tag belongs to
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id the tag belongs to
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// id of the resource
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// resource type
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// tag value
        /// </summary>
        public string Value { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
