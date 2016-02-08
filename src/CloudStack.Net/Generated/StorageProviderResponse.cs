using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StorageProviderResponse
    {
        /// <summary>
        /// the name of the storage provider
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the type of the storage provider: primary or image provider
        /// </summary>
        public string Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
