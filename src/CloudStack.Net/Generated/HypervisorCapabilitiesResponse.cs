using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HypervisorCapabilitiesResponse
    {
        /// <summary>
        /// the ID of the hypervisor capabilities row
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the hypervisor type
        /// </summary>
        public HypervisorType Hypervisor { get; set; }

        /// <summary>
        /// the hypervisor version
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// the maximum number of Data Volumes that can be attached for this hypervisor
        /// </summary>
        public int MaxDataVolumesLimit { get; set; }

        /// <summary>
        /// the maximum number of guest vms recommended for this hypervisor
        /// </summary>
        public long MaxGuestsLimit { get; set; }

        /// <summary>
        /// the maximum number of Hosts per cluster for this hypervisor
        /// </summary>
        public int MaxHostsPerCluster { get; set; }

        /// <summary>
        /// true if security group is supported
        /// </summary>
        public bool Securitygroupenabled { get; set; }

        /// <summary>
        /// true if storage motion is supported
        /// </summary>
        public bool Storagemotionenabled { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
