using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BaremetalPxeKickStartResponse
    {
        /// <summary>
        /// Tftp root directory of PXE server
        /// </summary>
        public string TftpDir { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
