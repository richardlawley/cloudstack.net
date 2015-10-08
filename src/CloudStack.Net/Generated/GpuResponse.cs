using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GpuResponse
    {
        /// <summary>
        /// GPU cards present in the host
        /// </summary>
        public string GpuGroupName { get; set; }

        /// <summary>
        /// the list of enabled vGPUs
        /// </summary>
        public IList<VgpuResponse> Vgpu { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
