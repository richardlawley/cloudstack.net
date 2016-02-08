using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiSolidFireVolumeAccessGroupIdResponse
    {
        /// <summary>
        /// SolidFire Volume Access Group Id
        /// </summary>
        public long SolidFireVolumeAccessGroupId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
