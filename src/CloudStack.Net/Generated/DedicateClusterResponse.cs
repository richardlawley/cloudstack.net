using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateClusterResponse
    {
        /// <summary>
        /// the ID of the dedicated resource
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the Account ID of the cluster
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the Dedication Affinity Group ID of the cluster
        /// </summary>
        public string AffinityGroupId { get; set; }

        /// <summary>
        /// the ID of the cluster
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// the name of the cluster
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// the domain ID of the cluster
        /// </summary>
        public string DomainId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
