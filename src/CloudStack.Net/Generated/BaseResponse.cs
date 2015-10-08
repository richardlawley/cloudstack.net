using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BaseResponse
    {
        /// <summary>
        /// the UUID of the latest async job acting on this object
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// the current status of the latest async job acting on this object
        /// </summary>
        public int JobStatus { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
