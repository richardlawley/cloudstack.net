using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DomainResponse
    {
        /// <summary>
        /// the ID of the domain
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the total number of cpu cores available to be created for this domain
        /// </summary>
        public string CpuAvailable { get; set; }

        /// <summary>
        /// the total number of cpu cores the domain can own
        /// </summary>
        public string CpuLimit { get; set; }

        /// <summary>
        /// the total number of cpu cores owned by domain
        /// </summary>
        public long CpuTotal { get; set; }

        /// <summary>
        /// whether the domain has one or more sub-domains
        /// </summary>
        public bool HasChild { get; set; }

        /// <summary>
        /// the total number of public ip addresses available for this domain to acquire
        /// </summary>
        public string IpAvailable { get; set; }

        /// <summary>
        /// the total number of public ip addresses this domain can acquire
        /// </summary>
        public string IpLimit { get; set; }

        /// <summary>
        /// the total number of public ip addresses allocated for this domain
        /// </summary>
        public long IpTotal { get; set; }

        /// <summary>
        /// the level of the domain
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// the total memory (in MB) available to be created for this domain
        /// </summary>
        public string MemoryAvailable { get; set; }

        /// <summary>
        /// the total memory (in MB) the domain can own
        /// </summary>
        public string MemoryLimit { get; set; }

        /// <summary>
        /// the total memory (in MB) owned by domain
        /// </summary>
        public long MemoryTotal { get; set; }

        /// <summary>
        /// the name of the domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the total number of networks available to be created for this domain
        /// </summary>
        public string NetworkAvailable { get; set; }

        /// <summary>
        /// the network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the total number of networks the domain can own
        /// </summary>
        public string NetworkLimit { get; set; }

        /// <summary>
        /// the total number of networks owned by domain
        /// </summary>
        public long NetworkTotal { get; set; }

        /// <summary>
        /// the domain ID of the parent domain
        /// </summary>
        public string ParentDomainId { get; set; }

        /// <summary>
        /// the domain name of the parent domain
        /// </summary>
        public string ParentDomainName { get; set; }

        /// <summary>
        /// the path of the domain
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) available to be used for this domain
        /// </summary>
        public string PrimaryStorageAvailable { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) the domain can own
        /// </summary>
        public string PrimaryStorageLimit { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) owned by domain
        /// </summary>
        public long PrimaryStorageTotal { get; set; }

        /// <summary>
        /// the total number of projects available for administration by this domain
        /// </summary>
        public string ProjectAvailable { get; set; }

        /// <summary>
        /// the total number of projects the domain can own
        /// </summary>
        public string ProjectLimit { get; set; }

        /// <summary>
        /// the total number of projects being administrated by this domain
        /// </summary>
        public long ProjectTotal { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) available to be used for this domain
        /// </summary>
        public string SecondaryStorageAvailable { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) the domain can own
        /// </summary>
        public string SecondaryStorageLimit { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) owned by domain
        /// </summary>
        public long SecondaryStorageTotal { get; set; }

        /// <summary>
        /// the total number of snapshots available for this domain
        /// </summary>
        public string SnapshotAvailable { get; set; }

        /// <summary>
        /// the total number of snapshots which can be stored by this domain
        /// </summary>
        public string SnapshotLimit { get; set; }

        /// <summary>
        /// the total number of snapshots stored by this domain
        /// </summary>
        public long SnapshotTotal { get; set; }

        /// <summary>
        /// the state of the domain
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the total number of templates available to be created by this domain
        /// </summary>
        public string TemplateAvailable { get; set; }

        /// <summary>
        /// the total number of templates which can be created by this domain
        /// </summary>
        public string TemplateLimit { get; set; }

        /// <summary>
        /// the total number of templates which have been created by this domain
        /// </summary>
        public long TemplateTotal { get; set; }

        /// <summary>
        /// the total number of virtual machines available for this domain to acquire
        /// </summary>
        public string VmAvailable { get; set; }

        /// <summary>
        /// the total number of virtual machines that can be deployed by this domain
        /// </summary>
        public string VmLimit { get; set; }

        /// <summary>
        /// the total number of virtual machines deployed by this domain
        /// </summary>
        public long VmTotal { get; set; }

        /// <summary>
        /// the total volume available for this domain
        /// </summary>
        public string VolumeAvailable { get; set; }

        /// <summary>
        /// the total volume which can be used by this domain
        /// </summary>
        public string VolumeLimit { get; set; }

        /// <summary>
        /// the total volume being used by this domain
        /// </summary>
        public long VolumeTotal { get; set; }

        /// <summary>
        /// the total number of vpcs available to be created for this domain
        /// </summary>
        public string VpcAvailable { get; set; }

        /// <summary>
        /// the total number of vpcs the domain can own
        /// </summary>
        public string VpcLimit { get; set; }

        /// <summary>
        /// the total number of vpcs owned by domain
        /// </summary>
        public long VpcTotal { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
