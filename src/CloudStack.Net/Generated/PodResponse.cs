using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PodResponse
    {
        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the allocation state of the Pod
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the ending IP for the Pod
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the gateway of the Pod
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the name of the Pod
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the netmask of the Pod
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the starting IP for the Pod
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the Zone ID of the Pod
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the Pod
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the capacity of the Pod
        /// </summary>
        public IList<CapacityResponse> Capacity { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
