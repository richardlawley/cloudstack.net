using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetworkACLResponse
    {
        /// <summary>
        /// the ID of the ACL
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Description of the ACL
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// is ACL for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the Name of the ACL
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of the VPC this ACL is associated with
        /// </summary>
        public string VpcId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
