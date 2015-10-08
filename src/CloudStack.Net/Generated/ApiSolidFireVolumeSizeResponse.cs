using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiSolidFireVolumeSizeResponse
    {
        /// <summary>
        /// SolidFire Volume Size Including Hypervisor Snapshot Reserve
        /// </summary>
        public long SolidFireVolumeSize { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
