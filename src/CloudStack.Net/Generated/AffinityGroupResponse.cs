using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AffinityGroupResponse
    {
        /// <summary>
        /// the ID of the affinity group
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the affinity group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the description of the affinity group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain name of the affinity group
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the affinity group
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the name of the affinity group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project name of the affinity group
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project ID of the affinity group
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the type of the affinity group
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// virtual machine IDs associated with this affinity group
        /// </summary>
        public IList<string> VirtualmachineIds { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
