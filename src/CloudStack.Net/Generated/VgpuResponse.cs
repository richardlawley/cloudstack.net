using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VgpuResponse
    {
        /// <summary>
        /// Maximum vgpu can be created with this vgpu type on the given gpu group
        /// </summary>
        public long MaxCapacity { get; set; }

        /// <summary>
        /// Maximum displays per user
        /// </summary>
        public long MaxHeads { get; set; }

        /// <summary>
        /// Maximum X resolution per display
        /// </summary>
        public long MaxResolutionX { get; set; }

        /// <summary>
        /// Maximum Y resolution per display
        /// </summary>
        public long MaxResolutionY { get; set; }

        /// <summary>
        /// Maximum no. of vgpu per gpu card (pgpu)
        /// </summary>
        public long MaxVgpuPerPgpu { get; set; }

        /// <summary>
        /// Remaining capacity in terms of no. of more VMs that can be deployped with this vGPU type
        /// </summary>
        public long RemainingCapacity { get; set; }

        /// <summary>
        /// Model Name of vGPU
        /// </summary>
        public string Vgputype { get; set; }

        /// <summary>
        /// Video RAM for this vGPU type
        /// </summary>
        public long VideoRam { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
