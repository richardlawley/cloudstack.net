using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StorageTagResponse
    {
        /// <summary>
        /// the ID of the storage tag
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name of the storage tag
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the pool ID of the storage tag
        /// </summary>
        public long PoolId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
