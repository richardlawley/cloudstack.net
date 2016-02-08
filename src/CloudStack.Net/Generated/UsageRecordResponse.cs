using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UsageRecordResponse
    {
        /// <summary>
        /// the user account name
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the user account Id
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// number of cpu of resource
        /// </summary>
        public long CpuNumber { get; set; }

        /// <summary>
        /// speed of each cpu of resource
        /// </summary>
        public long CpuSpeed { get; set; }

        /// <summary>
        /// description of the usage record
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain the resource is associated with
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// end date of the usage record
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// True if the resource is default
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// True if the IPAddress is source NAT
        /// </summary>
        public bool IsSourceNat { get; set; }

        /// <summary>
        /// True if the IPAddress is system IP - allocated during vm deploy or lb rule create
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// memory allocated for the resource
        /// </summary>
        public long Memory { get; set; }

        /// <summary>
        /// virtual machine name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// id of the network
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// offering ID
        /// </summary>
        public string OfferingId { get; set; }

        /// <summary>
        /// the project name of the resource
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the resource
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// raw usage in hours
        /// </summary>
        public string RawUsage { get; set; }

        /// <summary>
        /// resource size
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// start date of the usage record
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// template ID
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// resource type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// usage in hours
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// id of the resource
        /// </summary>
        public string UsageId { get; set; }

        /// <summary>
        /// usage type ID
        /// </summary>
        public int UsageType { get; set; }

        /// <summary>
        /// virtual machine ID
        /// </summary>
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// virtual size of resource
        /// </summary>
        public long VirtualSize { get; set; }

        /// <summary>
        /// the zone ID
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
