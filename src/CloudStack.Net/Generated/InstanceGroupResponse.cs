using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class InstanceGroupResponse
    {
        /// <summary>
        /// the ID of the instance group
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the instance group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// time and date the instance group was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the domain name of the instance group
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the instance group
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the name of the instance group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project name of the instance group
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project ID of the instance group
        /// </summary>
        public string ProjectId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
