using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ServiceInstanceResponse
    {
        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the virtual machine
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// user generated name. The name of the virtual machine is returned if no displayname exists.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// the name of the domain in which the virtual machine exists
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain in which the virtual machine exists
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the name of the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project name of the vm
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vm
        /// </summary>
        public string ProjectId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
