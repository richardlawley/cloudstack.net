using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLunsCmdResponse
    {
        /// <summary>
        /// lun id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// lun iqn
        /// </summary>
        public string Iqn { get; set; }

        /// <summary>
        /// lun name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// volume id
        /// </summary>
        public long VolumeId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
