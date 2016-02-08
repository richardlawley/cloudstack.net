using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResourceLimitResponse
    {
        /// <summary>
        /// the account of the resource limit
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the resource limit
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the resource limit
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the maximum number of the resource. A -1 means the resource currently has no limit.
        /// </summary>
        public long Max { get; set; }

        /// <summary>
        /// the project name of the resource limit
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the resource limit
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// resource type. Values include 0, 1, 2, 3, 4, 6, 7, 8, 9, 10, 11. See the resourceType parameter for more information on these values.
        /// </summary>
        public string ResourceType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
