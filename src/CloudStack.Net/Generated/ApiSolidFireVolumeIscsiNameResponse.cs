using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiSolidFireVolumeIscsiNameResponse
    {
        /// <summary>
        /// SolidFire Volume Iscsi Name
        /// </summary>
        public string SolidFireVolumeIscsiName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
