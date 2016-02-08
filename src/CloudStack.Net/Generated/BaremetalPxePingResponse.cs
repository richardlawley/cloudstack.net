using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BaremetalPxePingResponse
    {
        /// <summary>
        /// Root directory on PING storage server
        /// </summary>
        public string PingDir { get; set; }

        /// <summary>
        /// PING storage server ip
        /// </summary>
        public string PingStorageServerIp { get; set; }

        /// <summary>
        /// Tftp root directory of PXE server
        /// </summary>
        public string TftpDir { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
