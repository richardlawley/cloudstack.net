using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaEnabledResponse
    {
        /// <summary>
        /// is quota service enabled
        /// </summary>
        public bool IsEnabled { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
