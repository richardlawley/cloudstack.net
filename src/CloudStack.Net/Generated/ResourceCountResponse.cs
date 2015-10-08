using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResourceCountResponse
    {
        /// <summary>
        /// the account for which resource count's are updated
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name for which resource count's are updated
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID for which resource count's are updated
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the project name for which resource count's are updated
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id for which resource count's are updated
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// resource count
        /// </summary>
        public long ResourceCount { get; set; }

        /// <summary>
        /// resource type. Values include 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11. See the resourceType parameter for more information on these values.
        /// </summary>
        public string ResourceType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
