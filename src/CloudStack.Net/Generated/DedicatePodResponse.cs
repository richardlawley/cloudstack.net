using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicatePodResponse
    {
        /// <summary>
        /// the ID of the dedicated resource
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the Account Id to which the Pod is dedicated
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the Dedication Affinity Group ID of the pod
        /// </summary>
        public string AffinityGroupId { get; set; }

        /// <summary>
        /// the domain ID to which the Pod is dedicated
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Name of the Pod
        /// </summary>
        public string PodName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
