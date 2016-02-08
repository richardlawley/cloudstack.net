using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProjectResponse
    {
        /// <summary>
        /// the id of the project
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account name of the project's owner
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the total number of cpu cores available to be created for this project
        /// </summary>
        public string CpuAvailable { get; set; }

        /// <summary>
        /// the total number of cpu cores the project can own
        /// </summary>
        public string CpuLimit { get; set; }

        /// <summary>
        /// the total number of cpu cores owned by project
        /// </summary>
        public long CpuTotal { get; set; }

        /// <summary>
        /// the displaytext of the project
        /// </summary>
        public string Displaytext { get; set; }

        /// <summary>
        /// the domain name where the project belongs to
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id the project belongs to
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the total number of public ip addresses available for this project to acquire
        /// </summary>
        public string IpAvailable { get; set; }

        /// <summary>
        /// the total number of public ip addresses this project can acquire
        /// </summary>
        public string IpLimit { get; set; }

        /// <summary>
        /// the total number of public ip addresses allocated for this project
        /// </summary>
        public long IpTotal { get; set; }

        /// <summary>
        /// the total memory (in MB) available to be created for this project
        /// </summary>
        public string MemoryAvailable { get; set; }

        /// <summary>
        /// the total memory (in MB) the project can own
        /// </summary>
        public string MemoryLimit { get; set; }

        /// <summary>
        /// the total memory (in MB) owned by project
        /// </summary>
        public long MemoryTotal { get; set; }

        /// <summary>
        /// the name of the project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the total number of networks available to be created for this project
        /// </summary>
        public string NetworkAvailable { get; set; }

        /// <summary>
        /// the total number of networks the project can own
        /// </summary>
        public string NetworkLimit { get; set; }

        /// <summary>
        /// the total number of networks owned by project
        /// </summary>
        public long NetworkTotal { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) available to be used for this project
        /// </summary>
        public string PrimaryStorageAvailable { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) the project can own
        /// </summary>
        public string PrimaryStorageLimit { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) owned by project
        /// </summary>
        public long PrimaryStorageTotal { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) available to be used for this project
        /// </summary>
        public string SecondaryStorageAvailable { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) the project can own
        /// </summary>
        public string SecondaryStorageLimit { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) owned by project
        /// </summary>
        public long SecondaryStorageTotal { get; set; }

        /// <summary>
        /// the total number of snapshots available for this project
        /// </summary>
        public string SnapshotAvailable { get; set; }

        /// <summary>
        /// the total number of snapshots which can be stored by this project
        /// </summary>
        public string SnapshotLimit { get; set; }

        /// <summary>
        /// the total number of snapshots stored by this project
        /// </summary>
        public long SnapshotTotal { get; set; }

        /// <summary>
        /// the state of the project
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the total number of templates available to be created by this project
        /// </summary>
        public string TemplateAvailable { get; set; }

        /// <summary>
        /// the total number of templates which can be created by this project
        /// </summary>
        public string TemplateLimit { get; set; }

        /// <summary>
        /// the total number of templates which have been created by this project
        /// </summary>
        public long TemplateTotal { get; set; }

        /// <summary>
        /// the total number of virtual machines available for this project to acquire
        /// </summary>
        public string VmAvailable { get; set; }

        /// <summary>
        /// the total number of virtual machines that can be deployed by this project
        /// </summary>
        public string VmLimit { get; set; }

        /// <summary>
        /// the total number of virtual machines running for this project
        /// </summary>
        public int VmRunning { get; set; }

        /// <summary>
        /// the total number of virtual machines stopped for this project
        /// </summary>
        public int VmStopped { get; set; }

        /// <summary>
        /// the total number of virtual machines deployed by this project
        /// </summary>
        public long VmTotal { get; set; }

        /// <summary>
        /// the total volume available for this project
        /// </summary>
        public string VolumeAvailable { get; set; }

        /// <summary>
        /// the total volume which can be used by this project
        /// </summary>
        public string VolumeLimit { get; set; }

        /// <summary>
        /// the total volume being used by this project
        /// </summary>
        public long VolumeTotal { get; set; }

        /// <summary>
        /// the total number of vpcs available to be created for this project
        /// </summary>
        public string VpcAvailable { get; set; }

        /// <summary>
        /// the total number of vpcs the project can own
        /// </summary>
        public string VpcLimit { get; set; }

        /// <summary>
        /// the total number of vpcs owned by project
        /// </summary>
        public long VpcTotal { get; set; }

        /// <summary>
        /// the list of resource tags associated with vm
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
