using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GuestOsMappingResponse
    {
        /// <summary>
        /// the ID of the Guest OS mapping
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the hypervisor
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// version of the hypervisor for mapping
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// is the mapping user defined
        /// </summary>
        public string IsUserDefined { get; set; }

        /// <summary>
        /// standard display name for the Guest OS
        /// </summary>
        public string Osdisplayname { get; set; }

        /// <summary>
        /// hypervisor specific name for the Guest OS
        /// </summary>
        public string OsNameForHypervisor { get; set; }

        /// <summary>
        /// the ID of the Guest OS type
        /// </summary>
        public string OsTypeId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
